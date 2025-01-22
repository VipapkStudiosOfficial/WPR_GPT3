using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.ZB
{
    public class CreateZBRequestDto
    {
        public string BedrijfsNaam { get; set; } = string.Empty;
        public string KvKNummer { get; set; } = string.Empty;
        public string Adres { get; set; } = string.Empty;
    }
}