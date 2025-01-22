using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Account
{
    public class NewAccountDto
    {
        public string Username { get; set; } = string.Empty;
        public string Token {get; set;} = string.Empty;
    }
}