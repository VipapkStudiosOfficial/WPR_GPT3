using backend.Models;

public class Abonnement
{
    public int AbonnementId { get; set; }
    public string Type { get; set; } = string.Empty; // 'Pay-as-you-go' of 'Prepaid'
    public DateTime StartDatum { get; set; }
    public DateTime EindDatum { get; set; }

    // Relatie: Een abonnement hoort bij één klant
    public int? ZHId { get; set; }
    public ZakelijkeHuurder? ZakelijkeHuurder { get; set; }
}
