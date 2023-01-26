using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    // El mocking se genera a través de una interface
    public interface ICliente
    {
        string ClienteNombre { get; set; }

        int Descuento { get; set; }

        int OrderTotal { get; set; }

        bool IsPremium { get; set; }

        string CrearNombreCompleto(string nombre, string apellido);
        TipoCliente GetClienteDetalle();
    }


    public class Cliente : ICliente
    {
        public string ClienteNombre { get; set; }
        
        public int Descuento { get; set; }
        
        public int OrderTotal { get; set; }

        public bool IsPremium { get; set; }

        public Cliente()
        {
            IsPremium = false;
            Descuento = 10;
        }

        public string CrearNombreCompleto(string nombre, string apellido)
        {
            if(string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentException("El nombre está en blanco");
            }
            Descuento = 30;
            ClienteNombre = $"{nombre} {apellido}";
            return ClienteNombre;
            
        }

        // Este método devuelve un tipo de cliente dependiendo del OderTotal
        public TipoCliente GetClienteDetalle()
        {
            if (OrderTotal < 500)
                return new  ClienteBasico();
            return new ClientePremium();
        }
    }

    // Herencia
    public class TipoCliente { }

    // Tipo Cliente Basico
    public class ClienteBasico : TipoCliente { }
    // Tipo Cliente Premiun
    public class ClientePremium : TipoCliente { }
}
