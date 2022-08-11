using System;
using System.Collections.Generic;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var equipo = new { Nombre = "Real Betis", NumeroLigas = 1 };
            Test(equipo);

            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona() { Nombre = "Raul", Apellido = "Albiol", Edad = 33 });
            personas.Add(new Persona() { Nombre = "Iago", Apellido = "Aspas", Edad = 30 });
            var resultado = personas.Where(a => a.Edad == 30);

            Console.ReadLine();
        }

        public static void Test(dynamic equipo)
        {
            Console.WriteLine(equipo.Nombre);
        }

    }

    class Persona
    {
         public string Nombre { get; set; }
        public string  Apellido { get; set; }
        public int Edad { get; set; }
    }
}