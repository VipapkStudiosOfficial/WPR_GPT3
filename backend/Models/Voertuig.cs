using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Voertuig
    {
        public int VoertuigId { get; set; }

        public string Type { get; set; } = string.Empty; // Bijvoorbeeld: 'Auto', 'Caravan', 'Camper'

        public string Merk { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public string Kenteken { get; set; } = string.Empty;

        public string Kleur { get; set; } = string.Empty;

        public string Status { get; set; } = "Beschikbaar"; // Bijvoorbeeld: 'Beschikbaar', 'Verhuurd', 'In reparatie'

        [Column(TypeName = "decimal(18,2)")]
        public decimal Prijs { get; set; }

        public string Huurder { get; set; } = string.Empty; // Naam van de huurder

        public DateTime? VerhuurDatum { get; set; } // Datum waarop het voertuig is verhuurd

        // Relatie: Een voertuig kan meerdere schades hebben
        public ICollection<Schade> Schades { get; set; } = new List<Schade>();

        // Relatie: Een voertuig kan meerdere huuraanvragen hebben
        public ICollection<HuurAanvraag> HuurAanvragen { get; set; } = new List<HuurAanvraag>();

        // Toegevoegd: Een samengestelde naam op basis van merk en model
        public string Naam => $"{Merk} {Model}";
    }
}
