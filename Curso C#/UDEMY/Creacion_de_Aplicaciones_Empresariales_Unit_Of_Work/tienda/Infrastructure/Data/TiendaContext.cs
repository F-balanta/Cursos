using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class TiendaContext : DbContext
    {
        public TiendaContext(DbContextOptions options) : base (options) {}

        public DbSet<Producto>? Productos {get;set;}
        public DbSet<Categoria>? Categorias {get;set;}
        public DbSet<Marca>? Marcas {get;set;}
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Rol>? Roles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder){
            
            // Este metodo Aplicara la configuracion de todas las clases que hereden de IEntityTypeConfiguration
            // En este caso sería MarcaConfiguration, ProductoCOnfiguration, CategoriaConfiguration
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        
    }
}