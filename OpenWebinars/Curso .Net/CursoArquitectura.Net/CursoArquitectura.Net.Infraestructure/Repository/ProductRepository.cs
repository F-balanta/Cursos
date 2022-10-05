using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CursoArquitectura.Net.Core.Entities;
using CursoArquitectura.Net.Core.Repository;
using CursoArquitectura.Net.Infraestructure.Data;
using CursoArquitectura.Net.Infraestructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace CursoArquitectura.Net.Infraestructure.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(CursoArquitecturaNetContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Product>> GetProductByNameAsync(string productName)
        {
            return await dbContext.Products
                .Where(x => x.ProductName.Contains(productName))
                .ToListAsync();
        }
    }
}
