namespace API.Helpers.Errors
{
    public class ApiException : ApiResponse
    {
        public ApiException(int statusCode, string? menssage = null, string? details = null) : base(statusCode, menssage)
        {
            Details = details;
        }

        // Esta propiedad tendra los detalles de la excepcion
        public string Details { get; set; }
    }
}
