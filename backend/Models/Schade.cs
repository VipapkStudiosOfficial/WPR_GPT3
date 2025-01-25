namespace backend.Models
{
    public class Schade
    {
        public int SchadeId { get; set; }

        // Foreign Key naar Voertuig
        public int VoertuigId { get; set; }

        // Foreign Key naar HuurAanvraag
        public int HuurAanvraagId { get; set; }

        public string Beschrijving { get; set; } = string.Empty;
        public DateTime SchadeDatum { get; set; }
        public string ReparatieOpmerkingen { get; set; } = string.Empty;
        public string Status { get; set; } = "Open";

        // Navigatie-eigenschap naar Voertuig
        public Voertuig Voertuig { get; set; } = null!;

        // Navigatie-eigenschap naar HuurAanvraag
        public HuurAanvraag HuurAanvraag { get; set; } = null!;

        // Foto's gekoppeld aan deze schade
        public List<FotoUrl> FotoUrls { get; set; } = new List<FotoUrl>();

        // Nieuwe eigenschap: Schademelder
        public string Schademelder { get; set; } = string.Empty;
    }
}
