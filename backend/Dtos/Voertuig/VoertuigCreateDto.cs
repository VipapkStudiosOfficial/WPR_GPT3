namespace backend.Dtos.Voertuig
{
    public class VoertuigCreateDto
    {
        public string Type { get; set; } = string.Empty; // 'Auto', 'Caravan', 'Camper'
        public string Merk { get; set; } = string.Empty;
        public string Kenteken { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Kleur { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; // 'Beschikbaar', 'Verhuurd', 'In reparatie'
        public decimal Prijs { get; set; }

        // Toegevoegde eigenschappen
        public string Huurder { get; set; } = string.Empty; // Naam van de huurder
        public DateTime? VerhuurDatum { get; set; } // Datum waarop het voertuig is verhuurd
    }
}
