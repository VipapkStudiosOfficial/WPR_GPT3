using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.Voertuig;

namespace backend.Mappers
{
    public static class VoertuigMappers
    {
        public static VoertuigDto ToVoertuigDto(this Voertuig voertuigModel){
            return new VoertuigDto{
                VoertuigId = voertuigModel.VoertuigId,
                Type = voertuigModel.Type,
                Merk = voertuigModel.Merk,
                Model = voertuigModel.Model,
                Kenteken = voertuigModel.Kenteken,
                Kleur = voertuigModel.Kleur,
                Status = voertuigModel.Status,
                Prijs = voertuigModel.Prijs
            };
        }

        public static Voertuig ToCreateVoertuigDto(this VoertuigCreateDto voertuigDto)
        {
            return new Voertuig{
                Type = voertuigDto.Type,
                Merk = voertuigDto.Merk,
                Model = voertuigDto.Model,
                Kenteken = voertuigDto.Kenteken,
                Kleur = voertuigDto.Kleur,
                Status = voertuigDto.Status,
                Prijs = voertuigDto.Prijs
            };
        }
    }
}