using System;

namespace Platzi_asp_net_core.Models
{
    public class EquipmentLoan
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public DateTime DeliverDate { get; set; }
        public DateTime DateReceived { get; set; }
        public string Observation { get; set; }
        public User User { get; set; }
        public int  Room_Id { get; set; }
        public LoadRoom Room { get; set; }
    }
}
