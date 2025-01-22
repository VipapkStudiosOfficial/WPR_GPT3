using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class ZakelijkeHuurder
    {
        [Key]
        public int ZHId {get; set;}
        public string Naam {get; set;} =string.Empty;
        public int? ZBId {get; set;}
        public ZakelijkeBeheerder? ZakelijkeBeheerder {get; set;}
        public List<HuurAanvraag> HuurAanvragen = new List<HuurAanvraag>();
    }
}