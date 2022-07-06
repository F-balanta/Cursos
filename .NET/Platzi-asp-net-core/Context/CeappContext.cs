using Microsoft.EntityFrameworkCore;
using Platzi_asp_net_core.Models;
using System.Collections.Generic;

namespace Platzi_asp_net_core.Context
{
    public class CeappContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<LoadRoom> LoadRooms { get; set; }
        public DbSet<EquipmentLoan> equipmentLoans { get; set; }

        public CeappContext(DbContextOptions<CeappContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Ingresando adatos a la memoria virtual

            var Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Role = Role.Student,
                    DNI = 1151970341,
                    Nombres = "Juan Felipe",
                    Apellidos = "Balanta Rentería",
                },
                new User()
                {
                    Id = 2,
                    DNI = 1151970342,
                    Role = Role.Administrator,
                    Nombres = "Juan David",
                    Apellidos = "Balanta Renteria",
                },
                new User()
                {
                    Id = 3,
                    DNI = 1151970343,
                    Role = Role.Concierge,
                    Nombres = "Victor David",
                    Apellidos = "Perea Perea"
                }
        };
            modelBuilder.Entity<User>().HasData(Users);

            var EquipmentList = new List<EquipmentLoan>()
            {
                new EquipmentLoan()
                {
                    Id = 1,
                    User_Id = 1151970341,
                    Room_Id = 1,
                    DeliverDate = System.DateTime.Today,
                    DateReceived = System.DateTime.UtcNow,
                    Observation = "Faltaron los cables",
                },
                new EquipmentLoan()
                {
                    Id = 2,
                    User_Id = 1151970342,
                    Room_Id = 2,
                    DeliverDate = System.DateTime.Today,
                    DateReceived = System.DateTime.UtcNow,
                    Observation = "Faltaron los cables",
                },
                new EquipmentLoan()
                {
                    Id = 3,
                    User_Id = 1151970343,
                    Room_Id = 3,
                    DeliverDate = System.DateTime.Today,
                    DateReceived = System.DateTime.UtcNow,
                    Observation = "Faltaron los cables",
                }
        };
            modelBuilder.Entity<EquipmentLoan>().HasData(EquipmentList);
            var loadroom = new LoadRoom();
            loadroom.Id = 1;
            loadroom.room = 3;
            loadroom.Entry_Date = System.DateTime.Today;
            loadroom.Departure_Date = System.DateTime.Now;
            loadroom.Observation = "Se entrega sin ninguna novedad";

            modelBuilder.Entity<LoadRoom>().HasData(loadroom);
        }
    }
}
