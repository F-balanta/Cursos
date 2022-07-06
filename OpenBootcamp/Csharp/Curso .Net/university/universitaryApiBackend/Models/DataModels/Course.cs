using System.ComponentModel.DataAnnotations;

namespace universitaryApiBackend.Models.DataModels
{
    public enum Level { Basic, Intermediate, Advanced }

    public class Course : BaseEntity
    {
        public string Name { get; set; } = String.Empty;
        [Required, MaxLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required, MaxLength]
        public string LongDescription { get; set; } = string.Empty;
        public string TargetAudience { get; set; } = string.Empty;
        public string Objetives { get; set; } = string.Empty;
        public string Requirements { get; set; } = string.Empty;
        public Level Level { get; set; }
    }

}
