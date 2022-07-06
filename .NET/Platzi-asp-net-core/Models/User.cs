using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Platzi_asp_net_core.Models

{
    public class User
    {
        
        public int Id { get; set; }
        public Role Role { get; set; }
        public int DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos{ get; set; }
    }
}


