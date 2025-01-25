namespace backend.Dtos.Schade
{
    public class SchadeDto
    {
        public int SchadeId { get; set; }
        public string HuurderNaam { get; set; } // Naam van de huurder
        public string VoertuigNaam { get; set; }
        public string Beschrijving { get; set; }
        public DateTime SchadeDatum { get; set; }
        public List<string> FotoUrls { get; set; } = new List<string>();
        public string ReparatieOpmerkingen { get; set; }
        public string Status { get; set; }
        public string Schademelder { get; set; }
    }
}
