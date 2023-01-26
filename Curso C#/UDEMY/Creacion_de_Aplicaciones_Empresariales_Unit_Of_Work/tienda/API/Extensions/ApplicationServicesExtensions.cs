using API.Helpers;
using API.Helpers.Errors;
using API.Services;
using AspNetCoreRateLimit;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace API.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()        //WithOrigins("https://dominio.com");
                    .AllowAnyMethod()               //WithMethods("GET","POST","PUT","DELETE",...)
                    .AllowAnyHeader());             //WithHeaders("accept", "content-type"...);
            });



        // Con las migraciones tenemos una  forma de controlar los cambios que se realizan hacia la base de datos
        // Estos cambios pueden ser el crear nuevas propiedades, quitarlas, agregar nuevas tablas
        // Actualizando el esquema de la base de datos
        public static async void ConfigureMigrations(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var context = services.GetRequiredService<TiendaContext>();
                    await context.Database.MigrateAsync();
                    await TiendaContextSeed.SeedAsync(context, loggerFactory);
                    await TiendaContextSeed.SeedRolesAsync(context, loggerFactory);
                }
                catch (Exception ex)
                {
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError(ex, "Ocurrio un error durante la migración");
                }
            }
        }
        // Este metodo de extensión agrega los servicios de implementación que son utilizados por toda la aplicación
        public static void AddApplicationServices(this IServiceCollection services)
        {
            // services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            // services.AddScoped<IProductoRepository, ProductoRepository>();
            // services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            // services.AddScoped<IMarcaRepository, MarcaRepository>();
            services.AddScoped<IPasswordHasher<Usuario>, PasswordHasher<Usuario>>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUnitOfWork, UnitOfWOrk>();
        }
        // Limito la cantidad de peticiones realziadas por el cliente hacia nuestro servidor
        public static void ConfigureRateLimitiong(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
            services.AddInMemoryRateLimiting();

            services.Configure<IpRateLimitOptions>(options =>
            {
                options.EnableEndpointRateLimiting = true;
                options.StackBlockedRequests = false;
                // Si se infringe el unmero de peticiones hacia la API se enviará un codigo de error 429
                // TO MANY REQUEST - Demsasiadas Solicitudes
                options.HttpStatusCode = 429;
                options.RealIpHeader = "X-Real-IP";
                options.GeneralRules = new List<RateLimitRule>
                {
                    // Reglas generales hacia cualquier endpoint por un periodo de 10 segundos
                    new RateLimitRule
                    {
                        // Endpoints
                        Endpoint = "*",
                        //Periodo de tiempo
                        Period = "10s",
                        // Cantidad de Peticiones
                        Limit = 2
                    }
                };
            });

        }

        public static void ConfigureApiVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(options =>
            {
                // Definimos una version para nuestra aplicación
                options.DefaultApiVersion = new ApiVersion(1, 0);
                // En caso de que el cliente llame a la APi sin especificar la version, tomará la versión por defecto.
                options.AssumeDefaultVersionWhenUnspecified = true;
                // Especifica como ingresar a una version
                //options.ApiVersionReader = new QueryStringApiVersionReader("ver");// Ejemplo https://localhost:5001/api/productos/?ver=1.0

                // Establecer Version Mediante encabezado
                //options.ApiVersionReader = new HeaderApiVersionReader("X-Version");


                // En este caso el cliente puede especificar una de estas 2 formas deversionado
                options.ApiVersionReader = ApiVersionReader.Combine(
                    new QueryStringApiVersionReader("ver"),
                    new HeaderApiVersionReader("X-Version"));

                // La Aplicacion puede especificar que versiones soporta
                options.ReportApiVersions = true;
            });
        }

        public static void AddJwt(this IServiceCollection services, IConfiguration configuration)
        {
            // Se agrega la seccion  JWT del appsetting.json
            services.Configure<JWT>(configuration.GetSection("JWT"));

            // Añadiendo autenticación - JWT
            // MEtodo de extension que agrega el servicio de autenticación
            services.AddAuthentication(options =>
            {
                // Mediante el objeto options definimos que tipo de autenticacion necesitamos
                // En este caso JWTBEARER AUTHENTICACION
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                // Con este metodo configuramos la informacion del token junto con la opcion o
                .AddJwtBearer(o =>
                {
                    // Definimos si necesitamos una conexion HTTPS
                    o.RequireHttpsMetadata = false; // Como estamos en pruebas lo dejamos en false, en caso contrario será TRUE
                    o.SaveToken = false;
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                        //Asigno este valor desde el archivo appsettings.json
                        ValidIssuer = configuration["JWT:Issuer"],
                        //Asigno este valor desde el archivo appsettings.json
                        ValidAudience = configuration["JWT:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]))
                    };
                });
        }

        // Metodo de extencion para la validacion de errores
        public static void AddValidationErrors(this IServiceCollection services)
        {
            // Modificando el comportamiento de la Api
            services.Configure<ApiBehaviorOptions>(options =>
            {
                // Obtiene el modelState
                options.InvalidModelStateResponseFactory = actionContext =>
                {
                    // Con esto puedo obtener los errores del ModelState
                    var errors = actionContext.ModelState.Where(u => u.Value.Errors.Count() > 0)// Si la cantidad de errores es mayor a 0

                                .SelectMany(u => u.Value.Errors)// obtengo el listado de Errores
                                .Select(u => u.ErrorMessage).ToArray();// De cada listado obtengo el mensaje de Error

                    var errorResponse = new ApiValidation()
                    {
                        Errors = errors
                    };
                    //
                    return new BadRequestObjectResult(errorResponse);
                };
            });
        }
    }
}