using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_con_LINQ
{
    class Empresa
    {

        public void datosEmpresa()
        {
            Console.WriteLine($"Empresa: {Nombre} con ID: {Id}");
        }


        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
