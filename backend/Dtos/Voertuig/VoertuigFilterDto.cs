namespace backend.Dtos.Voertuig
{
    public class VoertuigFilterDto
    {
        public string Type { get; set; }
        public string Huurder { get; set; }
        public DateTime? StartDatum { get; set; }
        public DateTime? EindDatum { get; set; }
    }
}
