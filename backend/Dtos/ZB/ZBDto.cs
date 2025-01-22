using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Dtos.ZB
{
    public class ZBDto
    {
        public int ZBId {get; set;}
        public string BedrijfsNaam { get; set; } = string.Empty;
        public string KvKNummer { get; set; } = string.Empty;
        public string Adres { get; set; } = string.Empty;
        public List<ZakelijkeHuurder> ZakelijkeHuurders = new List<ZakelijkeHuurder>();
    }
}