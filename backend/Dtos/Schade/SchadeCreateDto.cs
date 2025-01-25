namespace backend.Dtos.Schade
{
    public class SchadeCreateDto
    {
        public int HuurAanvraagId { get; set; } // Koppeling met de huuraanvraag
        public string Beschrijving { get; set; }
        public DateTime SchadeDatum { get; set; }
        public List<string> FotoUrls { get; set; } = new List<string>();
        public string Schademelder { get; set; }
    }
}
