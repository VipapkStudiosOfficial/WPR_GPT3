using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Account
{
    public class RegisterDto
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? PhoneNumber {get; set;}
        [EmailAddress]
        public string Email {get; set;} = string.Empty;
        public int? PHId {get; set;}
        public int? ZBId {get; set;}
        public int? ZHId {get; set;}
        public int? MedewerkerId {get; set;}
    }
}