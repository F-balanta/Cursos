using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Usuario : BaseEntity
    {
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        //? Username e Email van a tener el mismo valor cuando se cree un nuevo usuario
        public string Username { get; set; }
        //? Username e Email van a tener el mismo valor cuando se cree un nuevo usuario
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Rol> Roles { get; set; } = new HashSet<Rol>();
       
        public ICollection<RefreshToken>? RefreshTokens { get; set; }
        public ICollection<UsuariosRoles>? UsuariosRoles { get; set; }
    }
}
