using System.ComponentModel.DataAnnotations;

public class ParticuliereHuurder 
{
    [Key]
    public int PHId { get; set; }
    public string Naam {get; set;} = string.Empty;
    public string Adres {get; set;} = string.Empty;
    public List<Abonnement> Abonnementen {get; set;} = new List<Abonnement>();//Relatie: klant kan meerdere abonnementen hebben
}