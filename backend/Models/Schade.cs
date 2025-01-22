public class Schade
{
    public int SchadeId { get; set; }
    public string Beschrijving { get; set; } = string.Empty;
    public DateTime Datum { get; set; }
    public string Status { get; set; } = string.Empty;
    // 'In behandeling', 'Afgehandeld'

    // Relatie: Elke schade hoort bij één voertuig
    public int? VoertuigId { get; set; }
    public Voertuig? Voertuig { get; set; } = new Voertuig();
}
