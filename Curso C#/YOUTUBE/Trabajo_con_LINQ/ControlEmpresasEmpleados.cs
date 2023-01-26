using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_con_LINQ
{
    internal class ControlEmpresasEmpleados
    {
        public ControlEmpresasEmpleados()
        {
            // Inicializamos las lista para Empresas y Empleados
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa {Id = 1, Nombre = "Google"});
            listaEmpresas.Add(new Empresa {Id = 2, Nombre = "Pildoras Informaticas"});
            listaEmpresas.Add(new Empresa {Id = 3, Nombre = "Unity"});
            listaEmpresas.Add(new Empresa {Id = 4, Nombre = "Carvajal"});
            listaEmpresas.Add(new Empresa {Id = 5, Nombre = "BalanTICS"});
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "David Balanta", cargoEmpleado = ".Net Developer", EmpresaID = 4, Salario = 3500000 });            
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Felipe Balanta", cargoEmpleado = "Game Developer", EmpresaID = 1, Salario = 3400000 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Gina Vanessa", cargoEmpleado = "Auxiliar Enfermeria", EmpresaID = 2, Salario = 30000 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Yeison perea", cargoEmpleado = "Mantenimiento", EmpresaID = 3, Salario = 5280000 });
            listaEmpleados.Add(new Empleado { Id = 5, Nombre = "Victor Manuel", cargoEmpleado = "Guaraño", EmpresaID = 5, Salario = 3958711 });

        }

        public void getDeveloper()
        {
            IEnumerable<Empleado> Developers = from empleado in listaEmpleados where empleado.cargoEmpleado == ".Net Developer" select empleado;

            foreach (Empleado empleado1 in Developers)
            {
                empleado1.datosEmpleado();
            }
        }
        public void OrderByName()
        {
            IEnumerable<Empleado> EmplooyesOrderByName = from empleado in listaEmpleados orderby empleado.Nombre select empleado;
            foreach(Empleado empleado1 in EmplooyesOrderByName)
            {
                empleado1.datosEmpleado();
            }
        }
        public void OrderByEMpresas()
        {
            IEnumerable<Empresa> EmpresasOrderByName = from empresa in listaEmpresas orderby empresa.Nombre select empresa;
            foreach (Empresa empresa1 in EmpresasOrderByName)
            {
                empresa1.datosEmpresa();
            }
        }
        public void empleadosPildoras()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              join empresa in listaEmpresas
                                              on empleado.EmpresaID equals empresa.Id
                                              where empresa.Nombre =="Pildoras Informaticas" select empleado;
            foreach (Empleado empleado1 in empleados)
            {
                empleado1.datosEmpleado();
            }

        }
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;
    }
}
