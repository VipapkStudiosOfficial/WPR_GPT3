using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class ZakelijkeBeheerder
    {
        [Key]
        public int ZBId { get; set; }
        public string BedrijfsNaam { get; set; } = string.Empty;
        public string KvKNummer { get; set; } = string.Empty;
        public string Adres { get; set; } = string.Empty;
        public List<ZakelijkeHuurder> ZakelijkeHuurders = new List<ZakelijkeHuurder>();
    }
}