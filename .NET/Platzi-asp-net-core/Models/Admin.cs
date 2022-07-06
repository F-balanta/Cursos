namespace Platzi_asp_net_core.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string Password { get; set; }
        public User User { get; set; }
    }
}
