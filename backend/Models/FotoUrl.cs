namespace backend.Models
{
    public class FotoUrl
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public int SchadeId { get; set; }
        public Schade Schade { get; set; } = null!;
    }
}
