using backend.Models;

public class HuurAanvraag
{
    public int HuurAanvraagId { get; set; }
    public DateTime StartDatum { get; set; }
    public DateTime EindDatum { get; set; }
    public string Status { get; set; } = string.Empty;// 'In behandeling', 'Goedgekeurd', 'Afgewezen'

    // Relatie: Elke aanvraag is van een huurder
    public int? ZHId { get; set; }
    public ZakelijkeHuurder? ZakelijkeHuurder { get; set; } = new ZakelijkeHuurder();

    // Relatie: Elke aanvraag is voor één voertuig
    public int? VoertuigId { get; set; }
    public Voertuig? Voertuig { get; set; } = new Voertuig();
}
