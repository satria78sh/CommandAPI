using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Models
{
    public class Commmand
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Maxlenght(250)]
        public string HowTo { get; set; }

        [Required]
        public string Platform { get; set; }

        [Required]
        public string CommandLine { get; set; }
    }
}