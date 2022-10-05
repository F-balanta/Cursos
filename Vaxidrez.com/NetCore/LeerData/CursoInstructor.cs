using System;
using System.Collections.Generic;
using System.Text;

namespace LeerData
{
    public class CursoInstructor
    {
        public int InstructorId { get; set; }
        public int CursoId { get; set; }

        public Curso Curso { get; set; }
        public Instructor Instructor { get; set; }
    }
}
