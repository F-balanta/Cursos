using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Aplicacion.ManejadorError
{
    public class ManejadorExcepcion : Exception
    {
        public HttpStatusCode Codigo { get; }
        public object Errores { get; }
        

        public ManejadorExcepcion(HttpStatusCode codigo, Object errores = null)
        {
            Errores = errores;
            Codigo = codigo;
        }
    }
}
