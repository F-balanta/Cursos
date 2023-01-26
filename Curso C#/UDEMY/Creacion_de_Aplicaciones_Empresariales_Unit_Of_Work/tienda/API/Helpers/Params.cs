using System.Net.WebSockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class Params
    {
        private int _pageSize = 5;
        private const int MaxPageSize = 50;
        public int _pageIndex = 1;

        // Propiedad que envia el cliente para realizar el filtro
        private string? _search;

        public int PageSize  // Numero de registros por pagina 
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
        public int PageIndex // Contiene el indice de la pagina
        {
            get => _pageIndex;
            set => _pageIndex = (value <= 0) ? 1 : value;
        }


        public string Search
        {
            get => _search!;
            // Valida que no sea nulo el valor que se va a asignar
            // Si no lo es lo comvierte en misnucular el valor
            // En caso contrario se pasa una cadena vacia
            set => _search = (!String.IsNullOrEmpty(value))?value.ToLower():"";
        }
    }
}