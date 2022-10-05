using System.Security.AccessControl;
using System.Threading.Tasks;
using Aplicacion.Seguridad;
using Dominio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    /**
     * Actualemente el prroyecto está protegido de los usuarios no autenticados señalando todos los metodos
     * de los controladores
     * Pero para poder hacer uso del login hay que desabilitar la proteccion
     * [AllowAnonymous] = Podemos desabilitar la proteccion con esta notación 
     */
    [AllowAnonymous]
    public class UsuarioController : MiControllerBase
    {
        //http://localhost:5000/api/usuario/login
        [HttpPost("login")]
        public async Task<ActionResult<UsuarioData>> Login(Login.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }
        //http://localhost:5000/api/usuario/registrar
        [HttpPost("registrar")]
        public async Task<ActionResult<UsuarioData>> Registrar(Registrar.Ejecuta parametros)
        {
            return await Mediator.Send(parametros);
        }

        [HttpGet]
        public async Task<ActionResult<UsuarioData>> DevolverUsuario()
        {
            return await Mediator.Send(new UsuarioActual.Ejecutar());
        }
    }
}
