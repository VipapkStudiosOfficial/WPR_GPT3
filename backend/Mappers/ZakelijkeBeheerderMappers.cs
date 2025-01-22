using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.ZB;
using backend.Models;

namespace backend.Mappers
{
    public static class ZakelijkeBeheerderMappers
    {
        public static ZBDto ToZBDto(this ZakelijkeBeheerder zBModel){
            return new ZBDto{
                ZBId = zBModel.ZBId,
                BedrijfsNaam = zBModel.BedrijfsNaam,
                KvKNummer = zBModel.KvKNummer,
                Adres = zBModel.Adres,
            };
        }
        public static ZakelijkeBeheerder ToZBFromCreateDTO(this CreateZBRequestDto zBDto){
            return new ZakelijkeBeheerder{
                BedrijfsNaam = zBDto.BedrijfsNaam,
                KvKNummer = zBDto.KvKNummer,
                Adres = zBDto.Adres,
            };
        }
    }
}