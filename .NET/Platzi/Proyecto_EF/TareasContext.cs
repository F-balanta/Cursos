using Microsoft.EntityFrameworkCore;
using Proyecto_EF.Models;

namespace Proyecto_EF
{
    // DbContext es una clase de entity framework que contiene todos los  componentes que nesesita la clase TareasContext para hacer la configuracion de bases de datos
    public class TareasContext : DbContext
    {

        // Este metodo ya tiene la configuracion basica (:base)
        public TareasContext(DbContextOptions<TareasContext> options):base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Categoria> categoriasInit = new List<Categoria>();
            categoriasInit.Add(new Categoria() { CategoriaId = Guid.Parse("44a9d16c-131b-4402-9522-cc03b1f20530"), Nombre="Actividades Pendientes", Peso=20});
            categoriasInit.Add(new Categoria() { CategoriaId = Guid.Parse("44a9d16d-131b-4402-9522-cc03b1f20530"), Nombre="Actividades Personales", Peso=50});
            modelBuilder.Entity<Categoria>(categoria =>
            {
                categoria.ToTable("Categoria");
                categoria.HasKey(p => p.CategoriaId);
                categoria.Property(p => p.Nombre).IsRequired().HasMaxLength(150);
                categoria.Property(p => p.Descripcion).IsRequired(false);
                categoria.Property(p => p.Peso);
                categoria.HasData(categoriasInit);
            });
            List<Tarea> tareasInint = new List<Tarea>();
            tareasInint.Add(new Tarea() { TareaId = Guid.Parse("44a9d16c-131b-4402-9522-cc03b1f20531"), CategoriaId = Guid.Parse("44a9d16c-131b-4402-9522-cc03b1f20530"), PropridadTarea = Prioridad.Media, Titulo = "Pago de servicios publicos", FechaCreacion = DateTime.Now});
            tareasInint.Add(new Tarea() { TareaId = Guid.Parse("44a9d16c-131b-4402-9522-cc03b1f20532"), CategoriaId = Guid.Parse("44a9d16d-131b-4402-9522-cc03b1f20530"), PropridadTarea = Prioridad.Baja, Titulo = "Terminar de ver pelicula en Netlix", FechaCreacion = DateTime.Now });
            modelBuilder.Entity<Tarea>(tarea =>
                {
                    tarea.ToTable("Tarea");
                    tarea.HasKey(p => p.TareaId);
                    tarea.HasOne(p => p.Categoria).WithMany(p => p.Tareas).HasForeignKey(p=>p.CategoriaId);
                    tarea.Property(p => p.Titulo).IsRequired().HasMaxLength(200);
                    tarea.Property(p => p.Descriptcion).IsRequired(false);
                    tarea.Property(p => p.PropridadTarea);
                    tarea.Property(p => p.FechaCreacion);
                    tarea.Ignore(p => p.Resumen);
                    tarea.HasData(tareasInint);
                });
        }





        // Coleccion de datos de el modelo que se ha creado ejemplo categoria, Tarea
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
    }
}
