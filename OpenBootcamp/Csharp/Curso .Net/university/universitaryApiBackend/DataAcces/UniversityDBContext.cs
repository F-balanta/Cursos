using Microsoft.EntityFrameworkCore;
using universitaryApiBackend.Models.DataModels;

namespace universitaryApiBackend.DataAcces
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> opttions) : base(opttions)
        {

        }

        // TODO: Add Dbsets (Tablaes of our Data Base)
        public DbSet<User>? Users { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
