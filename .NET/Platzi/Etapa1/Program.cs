using System.Collections.Generic;
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Util;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.DibujarTitulo("BIENVENIDOS A LA ESCUELA");
            Printer.Beep();
            ImprimirCursosEscuela(engine.Escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.DibujarTitulo("Cursos de la Escuela");

            if (escuela?.cursos != null)// No va a verificar "cursos" slavo que "Escuela" sea diferente de nulo
            {
                foreach (var curso in escuela.cursos)
                {
                    Console.WriteLine($"Curso: {curso.Nombre}, Id: {curso.UniqueId}");
                }
            }
        }
    }
}