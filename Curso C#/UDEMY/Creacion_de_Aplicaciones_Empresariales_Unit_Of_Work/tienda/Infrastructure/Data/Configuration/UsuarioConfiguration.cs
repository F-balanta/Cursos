using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Nombres).IsRequired().HasMaxLength(200);
            builder.Property(p => p.ApellidoPaterno).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Username).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(200);

            builder
                .HasMany(p => p.Roles)
                .WithMany(p => p.Usuarios)
                .UsingEntity<UsuariosRoles>(
                    j => j
                            .HasOne(pt => pt.Rol)
                            .WithMany(t => t.UsuariosRoles)
                            .HasForeignKey(pt => pt.RolId),
                    j => j
                            .HasOne(pt => pt.Usuario)
                            .WithMany(t => t.UsuariosRoles)
                            .HasForeignKey(pt => pt.UsuarioId),
                    j =>
                    {
                        j.HasKey(t => new { t.UsuarioId, t.RolId });
                    });

            // Defino la relaci�n entre el usuario y los tokens 
            builder.HasMany(p => p.RefreshTokens)
                .WithOne(p => p.Usuario)
                .HasForeignKey(p => p.UsuarioId);
        }
    }
}