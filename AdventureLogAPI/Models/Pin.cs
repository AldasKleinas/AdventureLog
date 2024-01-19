using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureLogAPI.Models
{
    public class Pin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public int IconId { get; set; }

        public int MapId { get; set; }

        [ForeignKey("IconId")]
        public Icon? Icon { get; set; }

        [ForeignKey("MapId")]
        public Map? Map { get; set; }

        public List<PinNote>? Notes { get; set; }
    }
}