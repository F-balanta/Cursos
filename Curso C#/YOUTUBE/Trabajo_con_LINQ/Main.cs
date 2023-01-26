using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_con_LINQ
{
    class Programa
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados control = new ControlEmpresasEmpleados();

            control.getDeveloper();
            control.OrderByName();
            control.OrderByEMpresas();
            control.empleadosPildoras();
        }
    }
}
