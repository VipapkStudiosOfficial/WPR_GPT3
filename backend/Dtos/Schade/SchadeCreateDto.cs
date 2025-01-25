using System.ComponentModel.DataAnnotations;

namespace backend.Dtos.Schade
{
    public class SchadeCreateDto
    {
        [Required]
        public int HuurAanvraagId { get; set; } // Koppeling met de huuraanvraag

        [Required]
        public int VoertuigId { get; set; } // Koppeling met het voertuig

        [Required]
        public string Beschrijving { get; set; }

        [Required]
        public DateTime SchadeDatum { get; set; }

        public List<string> FotoUrls { get; set; } = new List<string>();

        [Required]
        public string Schademelder { get; set; }
    }
}
