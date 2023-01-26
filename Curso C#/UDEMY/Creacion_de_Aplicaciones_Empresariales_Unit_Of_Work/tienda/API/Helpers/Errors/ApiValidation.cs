namespace API.Helpers.Errors
{
    public class ApiValidation : ApiResponse
    {
        // Ya que esta clase se encarga de los errores de validación y heredamos de ApiResponse
        // debemos de enviarle el StatusCode desde el contructor al constructor padre
        public ApiValidation() : base(400)
        {

        }
        //Este arreglo guardará  los mensajes de errors
        public IEnumerable<string> Errors { get; set; }
    }
}
