public class Medewerker
{
    public int MedewerkerId { get; set; }
    public string Naam { get; set; }= string.Empty;

    // Relatie: Medewerker verwerkt meerdere huur aanvragen
    public List<HuurAanvraag> HuurAanvragen { get; set; } = new List<HuurAanvraag>();
}
