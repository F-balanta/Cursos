using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoArquitectura.Net.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CursoArquitectura.Net.Infraestructure.Data
{
    public class CursoArquitecturaNetContext : DbContext
    {
        public CursoArquitecturaNetContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
