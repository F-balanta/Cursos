using API.DTOs;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class UsuariosController : BaseApiController
    {
        private readonly IUserService _userService;

        public UsuariosController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        // Este metodo va a llamar al servicio y va a devolver un resultado
        public async Task<ActionResult> RegisterAsync(RegisterDto model)
        {
            var result = await _userService.RegisterAsync(model);
            return Ok(result);
        }


        [HttpPost("token")]
        public async Task<IActionResult> GetTokenAsync(LoginDto model)
        {
            var result = await _userService.GetTokenAsync(model);
            SetRefreshTokenInCookie(result.RefreshToken);
            return Ok(result);
        }


        [HttpPost("addrole")]
        // Este método se encargará de agregar un rol determinado a un usuario
        public async Task<IActionResult> AddRoleAsync(AddRoleDto model)
        {
            var result = await _userService.AddRoleAsync(model);
            return Ok(result);
        }


        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken()
        {
            // De las cookies obtengo el refresh Token
            var refreshToken = Request.Cookies["refreshToken"];

            // llama a refresh Token Async, para obtener un nuevo token
            var response = await _userService.RefreshTokenAsync(refreshToken!);
            if (!string.IsNullOrEmpty(response.RefreshToken))
                SetRefreshTokenInCookie(response.RefreshToken);
            return Ok(response);
        }
        // Este método permitira almacera el refresh token en una cookie
        // Esto puede ser una mala practica ya que envia el token y el refresh token nuevamente al servidor haciendolo
        // vulnerable a ataques
        // Este metodo recibe como parametro el refreshToken
        // Este refresh token lo asignamos a una cookie
        private void SetRefreshTokenInCookie(string refreshToken)
        {
            var cookieOption = new CookieOptions
            {
                HttpOnly= true,
                // Se le da un tiempo de expiración de 10 dias a la cookie
                Expires = DateTime.UtcNow.AddDays(10),
            };
            // Y la cookie se llamará "refreshToken"
            Response.Cookies.Append("refreshToken", refreshToken, cookieOption);

        }
    }
}
