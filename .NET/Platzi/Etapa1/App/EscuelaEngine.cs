using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                ciudad: "Bogota", pais: "Colombia");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            List<Asignatura> listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{ Nombre = "Matematicas"},
                    new Asignatura{ Nombre = "Educacion Fisica"},
                    new Asignatura{ Nombre = "Castellano"},
                    new Asignatura{ Nombre = "Ciencias Naturales"},
                };
            foreach (var curso in Escuela.cursos)
            {

                curso.Asignaturas = listaAsignaturas;
            }
        }

        private IEnumerable<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Jhonatan", "David", "Francisco", "Vistor", "Mariana", "Leusemio", "Jeniffer", "Monica", "Larry", "Laurita" };
            string[] apellido1 = { "Vasquez", "Gonzales", "Chipaquira", "Balanta", "Renteria", "Ocoro", "Perea", "Mondragon", "Benitez"};
            string[] nombre2 = {"Tatiana", "Jenny", "Rodolfo", "Messi", "Cristiano", "Felipe", "Rosa", "Mirian", "Victoria", "Katiuska"};

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };
            //Ordenara la lista de alumnos por su UniqueId y luego toma los siguiente N cantidad de estudiantes dados
            return listaAlumnos.OrderBy((al)=> al.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.cursos = new List<Curso>{
                new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso() { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "401" , Jornada = TiposJornada.Tarde},
                new Curso() { Nombre = "501" , Jornada = TiposJornada.Tarde },
            };
            Random rnd = new Random();
            foreach(var c in Escuela.cursos)
            {
                int nramdom = rnd.Next(5, 25);
                c.Alumnos = (List<Asignatura>)GenerarAlumnosAlAzar(nramdom);
            }
        }
    }
}
