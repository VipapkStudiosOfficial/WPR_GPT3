using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class HuurAanvraag
    {
        [Key] // Markering als primaire sleutel
        public int Id { get; set; }

        [Required] // Verplicht veld
        [MaxLength(100)] // Maximale lengte instellen
        public string Naam { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)] // Status zoals "Pending", "Approved", "Rejected"
        public string Status { get; set; } = "Pending";

        [MaxLength(500)] // Optioneel afwijzingsreden
        public string? RejectReason { get; set; }

        [Required] // Datum van de aanvraag
        public DateTime AanvraagDatum { get; set; } = DateTime.UtcNow;

        // Foreign Key naar Voertuig
        [ForeignKey("Voertuig")] // Relatie met Voertuig
        public int VoertuigId { get; set; }

        // Navigatie-eigenschap
        public Voertuig Voertuig { get; set; } = null!;
    }
}