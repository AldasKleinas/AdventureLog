using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureLogAPI.Models
{
    public class Map
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImagePath { get; set; }

        public int CampaignId { get; set; }

        public List<Pin>? Pins { get; set; }

        [ForeignKey("CampaignId")]
        public Campaign Campaign { get; set; }

        public List<Character>? Characters { get; set; }
    }
}
