using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo) // Heredan del contructor base
        {
            Cilindrada = cilindrada;
        }

        public new void Arrancar()
        {
            Console.WriteLine("Arrancar moto");
        }
    }
}
