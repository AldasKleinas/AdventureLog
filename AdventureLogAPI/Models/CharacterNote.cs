using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureLogAPI.Models
{
    public class CharacterNote
    {
        [Key]
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Body { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public int UserId { get; set; }

        public int CharacterId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("CharacterId")]
        public Character Character { get; set; }
    }
}
