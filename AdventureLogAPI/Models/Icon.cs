using System.ComponentModel.DataAnnotations;

namespace AdventureLogAPI.Models
{
    public class Icon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? ImagePath { get; set; }

        public List<Character>? Characters { get; set; }

        public List<Pin>? Pins { get; set; }
    }
}
