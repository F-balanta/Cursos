using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploSealed
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo) // Heredan del contructor base
        {
            Cilindrada = cilindrada;
        }

        public sealed override void Arrancar()
        {
            Console.WriteLine("Arrancar moto");
        }
    }

    public class Triciclo : Moto
    {
        public int Cilindrada { get; set; }

        public Triciclo(string marca, string modelo, int cilindrada) : base(marca, modelo, cilindrada) // Heredan del contructor base
        {
            Cilindrada = cilindrada;
        }

        public void Arrancar()
        {
            Console.WriteLine("Arrancar Tricilo");
        }
    }
}
