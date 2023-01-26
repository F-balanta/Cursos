using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers;


// Clase generica que acepta un parametro de tipo Clase <class>
public class Pager<T> where T : class
{
    public string? Search { get; private set; }
    public int PageIndex { get; private set; } // Numero de pagina actual
    public int PageSize { get; private set; } // Tamaño total de registros por pagina
    public int Total { get; private set; } // Numero total de registros
    public IEnumerable<T>? Registers { get; private set; } // Numero total de registros que son resultados de la paginación


    public Pager(IEnumerable<T> registers, int total, int pageIndex, int pageSize, string? search)
    {
        Registers = registers;
        Total = total;
        PageIndex = pageIndex;
        PageSize = pageSize;
        Search = search;
    }

    public int TotalPages
    {
        get
        {
            return (int)Math.Ceiling(Total / (double)PageSize); // Resultado de total de registros
        }
    }
    public bool HasPreviousPage
    {
        get
        {
            return (PageIndex > 1);
        }
    }

    public bool HasNextPage
    {
        get
        {
            return (PageIndex < TotalPages);
        }
    }

}