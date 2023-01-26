using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        

        // Obtiene el precion del producto, este precio varia dependendiendo del
        // tipo de cliente
        public double GetPrecio(Cliente cliente)
        {
            // Si es cliente premium obtiene un descuento
            if (cliente.IsPremium)
            {
                return Precio * .8;
            }
            return Precio;
        }

        public double GetPrecio(ICliente cliente)
        {
            // Si es cliente premium obtiene un descuento
            if (cliente.IsPremium)
            {
                return Precio * .8;
            }
            return Precio;
        }
    }
}
