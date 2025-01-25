namespace backend.Dtos.Schade
{
    public class SchadeCreateDto
    {
        public int VoertuigId { get; set; }
        public string Beschrijving { get; set; } = string.Empty;
        public DateTime SchadeDatum { get; set; }
        public List<string> FotoUrls { get; set; } = new List<string>();
    }

}
