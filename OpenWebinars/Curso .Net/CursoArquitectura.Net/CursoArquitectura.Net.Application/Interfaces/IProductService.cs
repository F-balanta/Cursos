using System;
using System.Text;
using CursoArquitectura.Net.Core.Entities;

namespace CursoArquitectura.Net.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductList();
        Task<Product> GetProductById(int productId);
        Task<IEnumerable<Product>> GetProductByName(string product);
        Task<Product> Create(Product product);
        Task Update(Product product);
        Task Delete(Product product);
    }
}

