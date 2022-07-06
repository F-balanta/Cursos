using Microsoft.AspNetCore.Mvc;
using System;

namespace WebPersonal.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilPersonalController : ControllerBase
    {
        [HttpGet("leerperfil/{id}")]
        public string Get(int id)
        {
            return id switch
            {
                1 => "Ivan",
                2 => "Curso",
                _ => throw new NotSupportedException("el id no es valido")
            };
        }
        //[HttpPost("/")]
        public string Post(PerfilPersonaDto persona)
        {
            return $"{persona.Nombre} {persona.APellido}";
        }
    }
    public class PerfilPersonaDto
    {
        public string Nombre { get; set; }
        public string APellido { get; set; }
    }
}
