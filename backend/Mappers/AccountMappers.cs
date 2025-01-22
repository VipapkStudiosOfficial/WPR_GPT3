using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.Account;
using backend.Models;

namespace backend.Mappers
{
    public static class AccountMappers
    {
        public static AccountPHDto ToPHDto(this Account accountModel){
            return new AccountPHDto{
                PHId = accountModel.PHId
            };
        }
        public static AccountZBDto ToZBDto(this Account accountModel){
            return new AccountZBDto{
                ZBId  = accountModel.ZBId
            };
        }
        public static AccountZHDto ToZHDto(this Account accountModel){
            return new AccountZHDto{
                ZHId = accountModel.ZHId
            };
        }
        public static AccountMedewerkerDto ToMederwerkerDto(this Account accountModel){
            return new AccountMedewerkerDto{
                MedewerkerId = accountModel.MedewerkerId
            };
        }
        public static AccountInfoDto ToAccountDto(this Account accountModel){
            return new AccountInfoDto{
                Username = accountModel.UserName,
                Email = accountModel.Email,
                PhoneNumber = accountModel.PhoneNumber
            };
        }
    }
}