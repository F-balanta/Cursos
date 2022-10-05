using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoArquitectura.Net.Core.Entities;
using CursoArquitectura.Net.Core.Repository.Base;

namespace CursoArquitectura.Net.Core.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductByNameAsync(string productName);
    }
}