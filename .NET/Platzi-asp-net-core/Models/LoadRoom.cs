using System;

namespace Platzi_asp_net_core.Models
{
    public class LoadRoom
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int room { get; set; }
        public DateTime Entry_Date { get; set; }
        public DateTime Departure_Date { get; set; }
        public string Observation { get; set; }
        public User User { get; set; }
    }
}
