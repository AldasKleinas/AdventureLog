using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureLogAPI.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Race { get; set; }

        public string? Profession { get; set; }

        [Required]
        public int IconId { get; set; }

        [Required]
        public int CampaignId { get; set; }

        [ForeignKey("IconId")]
        public Icon? Icon { get; set; }

        [ForeignKey("CampaignId")]
        public Campaign? Campaign { get; set; }

        public List<CharacterNote>? Notes { get; set; }
    }
}
