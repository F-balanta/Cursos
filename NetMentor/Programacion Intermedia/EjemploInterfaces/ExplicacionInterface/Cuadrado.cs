using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicacionInterface
{
    internal class Cuadrado : IPieza
    {
        readonly decimal Lado;
        public Cuadrado(decimal lado)
        {
            Lado = lado;
        }

        public decimal Area()
        {
            return Lado * Lado;
        }

        public decimal Perimetro()
        {
            return Lado * 4;
        }
    }
}
