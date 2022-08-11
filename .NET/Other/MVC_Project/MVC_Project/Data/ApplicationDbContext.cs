using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

        /// <summary>
        /// Quiero que las columnas de la clase Usuario se visualizen en la tabla AspNetusers
        /// que viene por defecto en EF por lo que se debe de sobreescribir la configuración utilizando
        /// OnModelCreating
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Invocar el medoto de la clase padre
            //Se ejecua primero la configuración predefinida
            base.OnModelCreating(builder);

            builder.Entity<Usuario>(EntityTypeBuilder =>
            {
                EntityTypeBuilder.ToTable("Usuarios");

                EntityTypeBuilder.Property(u => u.UserName)
                    .HasMaxLength(100)
                    .HasDefaultValue(0);

                EntityTypeBuilder.Property(u => u.Sexo)
                    .HasMaxLength(1);
            });
        }
    }
    public class Usuario :IdentityUser
    {
        public char Sexo { get; set; }
        public string Pais { get; set; }
    }
}