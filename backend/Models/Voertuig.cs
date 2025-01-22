using System.ComponentModel.DataAnnotations.Schema;

public class Voertuig
{
    public int VoertuigId { get; set; }
    public string Type { get; set; } = string.Empty; // 'Auto', 'Caravan', 'Camper'
    public string Merk { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Kenteken { get; set; } = string.Empty;
    public string Kleur { get; set; } = string.Empty;
    public string Status { get; set; }  = string.Empty;// 'Beschikbaar', 'Verhuurd', 'In reparatie'
    [Column(TypeName ="decimal(18,2)")]
    public decimal Prijs {get; set;}

    // Relatie: Een voertuig kan meerdere schades hebben
    public List<Schade> Schades { get; set; } = new List<Schade>();
    public List<HuurAanvraag> HuurAanvragen {get; set;} = new List<HuurAanvraag>();
}
