namespace backend.Dtos.Voertuig
{
    public class VoertuigUpdateDto
    {
        public string? Type { get; set; } // Optioneel: 'Auto', 'Caravan', 'Camper'
        public string? Merk { get; set; } // Optioneel merk
        public string? Kenteken { get; set; } // Optioneel kenteken
        public string? Model { get; set; } // Optioneel model
        public string? Kleur { get; set; } // Optioneel kleur
        public string? Status { get; set; } // Optioneel: 'Beschikbaar', 'Verhuurd', 'In reparatie'
        public decimal? Prijs { get; set; } // Optionele prijs

        // Toegevoegde eigenschappen
        public string? Huurder { get; set; } // Optioneel: Naam van de huurder
        public DateTime? VerhuurDatum { get; set; } // Optioneel: Datum waarop het voertuig is verhuurd
    }
}
