using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicacionInterface
{
    internal class TrianguloRectangulo : IPieza
    {
        public decimal LadoA { get; set; }
        public decimal LadoB { get; set; }
        public decimal Hipotenusa { get; set; }
        public TrianguloRectangulo(decimal ladoA, decimal ladoB)

        {
            LadoA = ladoA;
            LadoB = ladoB;
            Hipotenusa = CalcularHipotenusa(ladoA, ladoB);
        }

        private decimal CalcularHipotenusa(decimal ladoa, decimal ladob)
        {
            return Convert.ToDecimal(Math.Sqrt((double)(ladoa * ladoa + ladob * ladob)));
        }

        public decimal Area()
        {
            return (LadoA * LadoB) / 2;
        }

        public decimal Perimetro()
        {
            return LadoA + LadoB + Hipotenusa;
        }
    }
}
