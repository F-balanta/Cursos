using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class Vehiculo
    {
        public void ArrancarMotor(string sonidoAlArrancar)
        {
            Console.WriteLine($"Arranca el motor: {sonidoAlArrancar}");
        }
        public void PararMotor(string sonidoAlParar)
        {
            Console.WriteLine($"Parando el motor: {sonidoAlParar}");
        }
        public virtual void Conducir()
        {
            Console.WriteLine("Este es el codigo generico para el metodo Conducir()");
        }
    }
}
