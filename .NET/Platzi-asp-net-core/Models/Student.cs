namespace Platzi_asp_net_core.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string Semester { get; set; }
        public string Career { get; set; }
        public User User { get; set; }
    }
}
