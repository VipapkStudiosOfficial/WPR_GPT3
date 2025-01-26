namespace backend.Models
{
    public class Schade
    {
        public int SchadeId { get; set; }
        public int VoertuigId { get; set; }
        public int HuurAanvraagId { get; set; }
        public string Beschrijving { get; set; } = string.Empty;
        public DateTime SchadeDatum { get; set; }
        public string ReparatieOpmerkingen { get; set; } = string.Empty;
        public string Status { get; set; } = "Open";
        public string Schademelder { get; set; } = string.Empty; // Voeg deze regel toe

        public Voertuig Voertuig { get; set; } = null!;
        public HuurAanvraag HuurAanvraag { get; set; } = null!;
        public List<FotoUrl> FotoUrls { get; set; } = new List<FotoUrl>();
    }
}
