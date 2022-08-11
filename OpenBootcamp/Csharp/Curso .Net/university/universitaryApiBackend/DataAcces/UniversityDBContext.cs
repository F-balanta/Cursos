using Microsoft.EntityFrameworkCore;
using universitaryApiBackend.Models.DataModels;

namespace universitaryApiBackend.DataAcces
{
    public class UniversityDBContext : DbContext
    {
        // El contexto es lo que nos permite trabajar con la base dedatos y sus diferentes modelos.
        public UniversityDBContext(DbContextOptions<UniversityDBContext> opttions) : base(opttions)
        {

        }

        // TODO: Add Dbsets (Tablaes of our Data Base)
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
    }
}
