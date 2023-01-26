using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_con_LINQ
{
    class Empleado
    {
        public void datosEmpleado()
        {
            Console.WriteLine($"EMpleado: {Nombre} con ID: {Id}, cargo {cargoEmpleado}," +
                $"con salario {Salario} pertenece a la empresa {EmpresaID}");
        }


        public int Id { get; set; }
        public string Nombre { get; set; }
        public string cargoEmpleado { get; set; }
        public double Salario { get; set; }
        // Clave foranea 

        public int EmpresaID { get; set; }
    }
}
