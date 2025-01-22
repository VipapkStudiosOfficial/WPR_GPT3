using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Voertuig
{
    public class VoertuigUpdateDto
    {
        public string Type { get; set; } = string.Empty; // 'Auto', 'Caravan', 'Camper'
        public string Merk { get; set; } = string.Empty;
        public string Kenteken { get; set; } = string.Empty;        
        public string Model { get; set; } = string.Empty;
        public string Kleur { get; set; } = string.Empty;
        public string Status { get; set; }  = string.Empty;// 'Beschikbaar', 'Verhuurd', 'In reparatie'
        public decimal Prijs {get; set;}
    }
}