using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IProductoRepository Productos {get;}
        ICategoriaRepository Categorias {get;}
        IMarcaRepository Marcas {get;}
        IUsuarioRepository Usuarios { get; }
        IRolRepository Roles { get; }
        Task<int> Save();
    }
}