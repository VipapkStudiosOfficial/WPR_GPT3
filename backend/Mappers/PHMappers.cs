using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.Klant;

namespace backend.Mappers
{
    public static class PHMappers
    {
        public static PHDto ToPHDto(this ParticuliereHuurder PHModel){
            return new PHDto{
                PHId = PHModel.PHId,
                Naam = PHModel.Naam,
                Adres = PHModel.Adres,
            };
        }
        public static ParticuliereHuurder ToPHFromCreateDTO(this CreatePHRequestDto zBDto){
            return new ParticuliereHuurder{
                Naam = zBDto.Naam,
                Adres = zBDto.Adres,
            };
        }
    }
}