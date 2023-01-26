using API.DTOs;
using API.Helpers;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace API.Services
{
    public class UserService : IUserService
    {
        private readonly JWT _jwt;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordHasher<Usuario> _passwordHasher;

        public UserService(IUnitOfWork unitOfWork, IOptions<JWT> jwt, IPasswordHasher<Usuario> passwordHasher)
        {
            _jwt = jwt.Value;
            _unitOfWork = unitOfWork;
            _passwordHasher = passwordHasher;
        }

        public async Task<DatosUsuarioDto> GetTokenAsync(LoginDto model)
        {
            DatosUsuarioDto datosUsuarioDto = new DatosUsuarioDto();
            // Obtengo el usuario con su Rol
            var usuario = await _unitOfWork.Usuarios.GetByUsernameAsync(model.Username);
            // Si el usuario no se encuentra => no existe
            if (usuario == null)
            {
                datosUsuarioDto.EstaAutenticado = false;
                datosUsuarioDto.Mensaje = $"No existe ningún usuario con el username {model.Username}.";
                return datosUsuarioDto;
            }
            
            var resultado = _passwordHasher.VerifyHashedPassword(usuario, usuario.Password, model.Password);
            // Si el usuario existe en la base de datos, verifica la contraseña encriptada de la base de datos
            // con el password que está pasando el cliente
            if (resultado == PasswordVerificationResult.Success)
            {
                // Si la validación es exitosa entonces el usuario está autenticado
                datosUsuarioDto.EstaAutenticado = true;
                // Genero el token de autenticación
                JwtSecurityToken jwtSecurityToken = CreateJwtToken(usuario);
                datosUsuarioDto.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
                //Asigno el email
                datosUsuarioDto.Email = usuario.Email;
                //Asigno el UserName
                datosUsuarioDto.UserName = usuario.Username;
                //Asigno el Rol
                datosUsuarioDto.Roles = usuario.Roles
                    .Select(u=>u.Nombre)
                    .ToList();

                // Si el ususario tiene algún refresh token que todavía esté activo 
                // entonces lo obtengo. se lo asigno a datoUsuarioDto y tambien asigno la expiración
                if (usuario.RefreshTokens!.Any(a=>a.IsActive))
                {
                    // Busca un tokenRefresh activo
                    var activeRefreshToken = usuario.RefreshTokens!.Where(a => a.IsActive == true).FirstOrDefault();
                    datosUsuarioDto.RefreshToken = activeRefreshToken!.Token;
                    datosUsuarioDto.RefreshTokenExpiration = activeRefreshToken.Expires;
                }
                // Si el refreshToken ya no está activo
                else
                {
                    // Creamos un nuevo refresh token
                    var refreshToken = CreateRefreshToken();
                    // Se lo asigno a datoUsuarioDto y tambien asigno la expiración
                    datosUsuarioDto.RefreshToken = refreshToken.Token;
                    datosUsuarioDto.RefreshTokenExpiration = refreshToken.Expires;
                    // Asigno el nuevo refresh token al usuario
                    usuario.RefreshTokens!.Add(refreshToken);
                    //Actualizamos los datos
                    _unitOfWork.Usuarios.Update(usuario);
                    // Guardamos cambios
                    await _unitOfWork.Save();
                }
                // por ultimo regreso datosUsuarioDto con el Token y RefreshToken
                return datosUsuarioDto;
            }
            // Si no fue exitosa la verificación del password entonces se asigna el bool a false
            // Se envia un mensaje
            datosUsuarioDto.EstaAutenticado = false;
            datosUsuarioDto.Mensaje = $"Credenciales incorrectas para el usuario {usuario.Username}.";
            return datosUsuarioDto;
        }

        public async Task<string> AddRoleAsync(AddRoleDto model)
        {
            // Obtiene los usuarios que tengan el username pasado por el cliente
            var usuario = await _unitOfWork.Usuarios.GetByUsernameAsync(model.Username);

            // Si el usuario es null, entonces revuelve una cadena
            if (usuario == null)
                return $"No existe algún usuario registrado con la cuenta {model.Username}";

            //Si no es null, validamos el password con el que está guardado en la base de datos
            var resultado = _passwordHasher.VerifyHashedPassword(usuario, usuario.Password, model.Password);
            // Si la verificacion es exitosa verificamos que el rol que intentamos agregar exista
            if (resultado == PasswordVerificationResult.Success)
            {
                var rolExiste = _unitOfWork.Roles.Find(u=>u.Nombre.ToLower() == model.Role.ToLower()).FirstOrDefault();

                if (rolExiste != null)
                {
                    // Ahora validamos si el usuario tiene asignado el rol psasado por el cliente
                    var usuarioTieneRol = usuario.Roles.Any(u=>u.Id == rolExiste.Id);

                    // Si es falso Añadiremos un nuevo rol
                    if (usuarioTieneRol == false)
                    {
                        // Añadimos el nuevo rol
                        usuario.Roles.Add(rolExiste);
                        // Ya que añadimos un nuevo rol debemos de actualizar la informacion del usuario
                        _unitOfWork.Usuarios.Update(usuario);
                        //Guardamos cambios
                        await _unitOfWork.Save();
                    }
                    // Devolvemos un mensaje indicambio el cambio del rol
                    return $"Rol {model.Role} agregado a la cuenta {model.Username} de forma exitosa.";
                }
                // En caso contrario de que el rol no exista, enviaremos un mensaje de error
                return $"Rol {model.Role} no encontrado.";
            }
            // Si las credenciales pasadas por el usuario son incorrrectas enviaremos un mensaje de error
            return $"Credenciales incorrectar para el usuario {usuario.Username}";
        }


        public async Task<DatosUsuarioDto> RefreshTokenAsync(string refreshToken)
        {
            var datosUsuarioDto = new DatosUsuarioDto();

            var usuario = await _unitOfWork.Usuarios.GetByRefreshTokenAsync(refreshToken);

            if (usuario == null)
            {
                datosUsuarioDto.EstaAutenticado = false;
                datosUsuarioDto.Mensaje = $"El token no pertenece a ningún usuario";
                return datosUsuarioDto;
            }

            var refreshTokenBd = usuario.RefreshTokens.Single(x => x.Token == refreshToken);

            if (!refreshTokenBd.IsActive)
            {
                datosUsuarioDto.EstaAutenticado = false;
                datosUsuarioDto.Mensaje = "El token no está activo.";
                return datosUsuarioDto;
            }

            // Revocamos el refresh Token actual
            refreshTokenBd.Revoked = DateTime.UtcNow;
            // Generamos un nuevo refresh token y lo guardamos en la base de datos
            var newRefreshToken = CreateRefreshToken();
            usuario.RefreshTokens.Add(newRefreshToken);
            _unitOfWork.Usuarios.Update(usuario);
            await _unitOfWork.Save();

            // Generamos un nuevo Json Web Token
            datosUsuarioDto.EstaAutenticado = true;
            JwtSecurityToken jwtSecurityToken = CreateJwtToken(usuario);
            datosUsuarioDto.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            datosUsuarioDto.Email = usuario.Email;
            datosUsuarioDto.UserName = usuario.Username;
            datosUsuarioDto.Roles = usuario.Roles
                    .Select(u => u.Nombre).ToList();
            datosUsuarioDto.RefreshToken = newRefreshToken.Token;
            datosUsuarioDto.RefreshTokenExpiration = newRefreshToken.Expires;

            return datosUsuarioDto;
        }



        // Método encargado de crear el refresh token
        private RefreshToken CreateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var generator = RandomNumberGenerator.Create())
            {
                generator.GetBytes(randomNumber);
                return new RefreshToken
                {
                    Token = Convert.ToBase64String(randomNumber),
                    Expires = DateTime.UtcNow.AddDays(10),
                    Created = DateTime.UtcNow
                };
            }
        }


        private JwtSecurityToken CreateJwtToken(Usuario usuario)
        {
            var roles = usuario.Roles;
            // Agregue los roles del usuario a una variable llamada roleClaims
            var roleClaims = new List<Claim>();

            foreach (var role in roles)
            {
                roleClaims.Add(new Claim("roles", role.Nombre));
            }
            // Los claims son un fragmento de informacion sobre un usuario
            var claims = new[]
            {
                        //Genero claims para el Username
                        new Claim(JwtRegisteredClaimNames.Sub, usuario.Username),
                        // Valor para una cadena jit
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        // un claim para el Email
                        new Claim(JwtRegisteredClaimNames.Email, usuario.Email),
                        // Y el ID del usuario
                        new Claim("uid", usuario.Id.ToString())

            }.Union(roleClaims);

            // Genero el token de autenticacion con los datos guardados en appsetting.json
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwt.DurationInMinutes),
                signingCredentials: signingCredentials);
            // regreso el token de seguridad
            return jwtSecurityToken;
        }


        public async Task<string> RegisterAsync(RegisterDto registerDto)
        {
            // Se establece la informacion del nuevo usuario con los datos paasados por el cliente
            var usuario = new Usuario
            {
                Nombres = registerDto.Nombres,
                ApellidoMaterno = registerDto.ApellidoMaterno,
                ApellidoPaterno = registerDto.ApellidoPaterno,
                Email = registerDto.Email,
                Username = registerDto.Username
            };
            // Encriptamos la contraseña pasada por el cliente
            // PasswordHasher pide como primer parametro el usuario que recibira la encriptación
            usuario.Password = _passwordHasher.HashPassword(usuario, registerDto.Password);

            // Valido si existe un usuario con ese username
            var usuarioExiste = _unitOfWork.Usuarios
                .Find(u => u.Username.ToLower() == registerDto.Username.ToLower()).FirstOrDefault();
            
            // Si el usuario no existe
            if (usuarioExiste == null)
            {
                // Busco el rol predeterminado
                var rolPredeterminado = _unitOfWork.Roles
                    .Find(u => u.Nombre == Autorizacion.rol_predeterminado.ToString()).First();

                try
                {
                    // Asigno el rol predeterminado al nuevo usuario
                    usuario.Roles.Add(rolPredeterminado);
                    // Agrego el nuevo usuario
                    _unitOfWork.Usuarios.Add(usuario);
                    // Guardo los cambios
                    await _unitOfWork.Save();

                    return $"el usuario { registerDto.Username } ha sido creado exitosamente.";
                }
                catch (Exception ex)
                {
                    // Si sale mal la creacion del usuario capturo el error y devuelvo un mensaje
                    var message = ex.Message;
                    return $"Error: {message}";
                }
            }
            else
            {
                // Si el usuario existe, envio un error con el nombre del usuario registrado
                return $"El usuario con { registerDto.Username } ya se encuentra registrado.";
            }
        }
    }
}
