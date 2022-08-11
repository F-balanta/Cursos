using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    internal abstract class TrianguloBase
    {
        public abstract decimal Perimetro();
        public abstract decimal Area();
        public double CalcularTrianguloconHipotenusa(int lado, int hipotenusa)
        {
            double ladob = Math.Sqrt(Math.Pow(hipotenusa,2) - Math.Pow(lado,2));
            return lado * ladob / 2;
        }
    }

    internal class Escaleno : TrianguloBase
    {
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }
    }
    internal class Acutangulo : TrianguloBase
    {
        public override decimal Area()
        {
            throw new NotImplementedException();
        }

        public override decimal Perimetro()
        {
            throw new NotImplementedException();
        }
    }
}
