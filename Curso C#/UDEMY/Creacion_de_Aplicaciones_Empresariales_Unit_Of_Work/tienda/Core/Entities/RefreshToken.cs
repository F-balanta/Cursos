﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class RefreshToken : BaseEntity
    {
        public int UsuarioId { get; set; } 
        public Usuario? Usuario { get; set; }// Variable de navegacion hacia el usuario
        public string Token { get; set; } = string.Empty;
        public DateTime Expires { get; set; }
        public bool IsExpired => DateTime.UtcNow >= Expires;
        public DateTime Created { get; set; }
        public DateTime Revoked { get; set; }
        public bool IsActive => Revoked == null && !IsExpired;
    }
}
