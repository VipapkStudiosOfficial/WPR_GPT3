namespace backend.Models
{
    public class Schade
    {
        public int SchadeId { get; set; }
        public int VoertuigId { get; set; }
        public string Beschrijving { get; set; } = string.Empty;
        public DateTime SchadeDatum { get; set; }
        public string ReparatieOpmerkingen { get; set; } = string.Empty;
        public string Status { get; set; } = "Open";

        public Voertuig Voertuig { get; set; } = null!;
        public List<FotoUrl> FotoUrls { get; set; } = new List<FotoUrl>(); // Relatie toegevoegd
    }
}
