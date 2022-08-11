using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Coche : Vehiculo
    {
        public string Traccion;
        public Coche(string marca, string modelo, string traccion) : base(marca,modelo)
        {
            Traccion = traccion;
        }
        public override void Arrancar()
        {
            Console.WriteLine("El coche está arrancando");
        }
    }
}
