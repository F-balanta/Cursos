namespace API.Helpers.Errors;

public class ApiResponse
{
    public int StatusCode { get; set; }
    public string Menssage { get; set; }

    // Estos valores se asignaran desde el constructor
    public ApiResponse(int statusCode, string menssage = null)
    {
        StatusCode = statusCode;
        // En caso de que el mensaje de error no contenga nada, por defecto va a ser nulo
        // Si este es nulo llamo a una funcion la cual le paso el codigo de estatus
        Menssage = menssage ?? GetDefaultMessage(StatusCode);
    }

    private string GetDefaultMessage(int statusCode)
    {
        return statusCode switch
        {
            400 => "Has realizado una peticion incorrecta.",
            401 => "usuario no autorizado.",
            404 => "El recurso que has intentado solicitar no existe.",
            405 => "Este mnétodo HTTP no está permitido en el servidor.",
            500 => "Error en el servidor. No eres tú, soy yo. Comunicate con un administrador"
        };
    }
}
