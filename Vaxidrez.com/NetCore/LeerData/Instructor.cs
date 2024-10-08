﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeerData
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Grado { get; set; }
        public byte[] FotoPerfil { get; set; }

        public ICollection<CursoInstructor> CursoLink { get; set; }
    }
}
