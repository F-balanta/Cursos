using System.Text.Json.Serialization;

namespace API.DTOs
{
    // Esta clase contiene los valores a devolver cuando se creé  el token de autenticación
    public class DatosUsuarioDto
    {
        public string Mensaje { get; set; }
        public bool EstaAutenticado { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<string>? Roles { get; set; }
        public string Token { get; set; }
        [JsonIgnore] //Atributo que restrunge que esta propiedad sea mostrada en los resultados Json
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
    }
}
