using System.Net;
using System.Text.Json;

namespace API.Helpers.Errors
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IHostEnvironment _env;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="next"></param>
        /// <param name="env">Cuando ocurra una excepcion esta será enviada al logger</param>
        /// <param name="hostEnvironment">Para saber si nuestra aplicacion se encuentra en un ambiente de produccion o no</param>
        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        // Todo componente Middleware usa el siguiente metodo y recibe como parametro un objeto  HttpContext
        // El cual tiene la información de la petición Http que se está realizando
        public async Task InvokeAsync(HttpContext context)
        {
            // Si no existe ningún error, este middleware procesa el siguiente componente middleware
            try
            {
                await _next(context);
            }
            // En caso de haberun error
            catch (Exception ex)
            {
                // En caso de una excepcion, producira un  Internal Server Error (error 505)
                var statusCode = (int)HttpStatusCode.InternalServerError;// guardo el codigo de error en la variable

                // Agrego el error al logger
                _logger.LogError(ex, ex.Message);
                // formateo la respuesta que se envia a Tipo JSOn
                context.Response.ContentType = "application/json";
                // Se le signa el codigo de estado 505 que es un Internal Server Error
                context.Response.StatusCode = statusCode;

                // si me encuentro en desarrollo entonces se envia el StackTrace - La pila de seguimiento
                var response = _env.IsDevelopment()
                    ? new ApiException(statusCode, ex.Message, ex.StackTrace.ToString())
                    // En caso de que se esté en produccion, solo se enviara el condigo de estado
                    : new ApiException(statusCode);

                // Debido a que la respues se va en pascualCase
                var options = new JsonSerializerOptions
                {
                    // lo convertimos en camel case
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };
                // Serializo el Json
                var json = JsonSerializer.Serialize(response, options);
                // Y lo envio en la respuesta
                await context.Response.WriteAsync(json);
            }
        }
    }
}
