namespace backend.Dtos.Schade
{
    public class SchadeDto
    {
        public int SchadeId { get; set; }
        public int VoertuigId { get; set; }
        public string Beschrijving { get; set; } = string.Empty;
        public DateTime SchadeDatum { get; set; }
        public List<string> FotoUrls { get; set; } = new List<string>();
        public string ReparatieOpmerkingen { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }

}
