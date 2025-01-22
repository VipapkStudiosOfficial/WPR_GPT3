using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Klant
{
    public class CreatePHRequestDto
    {
        public string Naam {get; set;} = string.Empty;
        public string Adres {get; set;} = string.Empty;
    }
}