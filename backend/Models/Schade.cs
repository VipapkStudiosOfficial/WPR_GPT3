using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class Schade
    {
        public int SchadeId { get; set; }
        public int VoertuigId { get; set; }
        public string Beschrijving { get; set; } = string.Empty;
        public DateTime SchadeDatum { get; set; }
        public List<string> FotoUrls { get; set; } = new List<string>();
        public string ReparatieOpmerkingen { get; set; } = string.Empty;
        public string Status { get; set; } = "Open";

        public Voertuig Voertuig { get; set; } = null!;
    }
}
