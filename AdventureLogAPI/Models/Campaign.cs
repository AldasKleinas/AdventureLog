using System.ComponentModel.DataAnnotations;

namespace AdventureLogAPI.Models
{
    public class Campaign
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Character>? Characters { get; set; }

        public List<Map>? Maps { get; set; }
    }
}
