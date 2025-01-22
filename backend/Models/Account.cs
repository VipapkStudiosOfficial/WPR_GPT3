using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace backend.Models
{
    public class Account : IdentityUser
    {
        public int? PHId { get; set; }
        public int? ZBId {get; set;}
        public int? ZHId {get; set;}
        public int? MedewerkerId {get; set;}
    }
}