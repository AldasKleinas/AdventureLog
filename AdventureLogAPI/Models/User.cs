using System.ComponentModel.DataAnnotations;

namespace AdventureLogAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Role { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public List<CharacterNote>? CharacterNotes { get; set; }

        public List<PinNote>? PinNotes { get; set; }
    }
}
