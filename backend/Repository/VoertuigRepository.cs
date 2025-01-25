using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Dtos.Voertuig;
using backend.Interfaces;
using Microsoft.EntityFrameworkCore;
using backend.Models;


namespace backend.Repository
{
    public class VoertuigRepository : IVoertuigRepository
    {
        private readonly ApplicationDBContext _context;

        public VoertuigRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Voertuig> CreateVoertuigAsync(Voertuig voertuigModel)
        {
            await _context.Voertuigen.AddAsync(voertuigModel);
            await _context.SaveChangesAsync();
            return voertuigModel;
        }

        public async Task<Voertuig?> DeleteAsync(int id)
        {
            var voertuigModel = await _context.Voertuigen.FirstOrDefaultAsync(v => v.VoertuigId == id);
            if (voertuigModel == null)
            {
                return null;
            }
            _context.Voertuigen.Remove(voertuigModel);
            await _context.SaveChangesAsync();
            return voertuigModel;
        }

        public async Task<List<Voertuig>> GetAllAsync()
        {
            return await _context.Voertuigen.ToListAsync();
        }

        public async Task<Voertuig?> GetByIdAsync(int id)
        {
            return await _context.Voertuigen.FindAsync(id);
        }

        public async Task<Voertuig?> UpdateAsync(int id, VoertuigUpdateDto voertuigUpdateDto)
        {
            var bestaandVoertuig = await _context.Voertuigen.FirstOrDefaultAsync(v => v.VoertuigId == id);

            if (bestaandVoertuig == null)
            {
                return null;
            }

            // Update de velden
            bestaandVoertuig.Status = voertuigUpdateDto.Status;
            bestaandVoertuig.Merk = voertuigUpdateDto.Merk;
            bestaandVoertuig.Model = voertuigUpdateDto.Model;
            bestaandVoertuig.Kenteken = voertuigUpdateDto.Kenteken;
            bestaandVoertuig.Type = voertuigUpdateDto.Type;
            bestaandVoertuig.Kleur = voertuigUpdateDto.Kleur;
            bestaandVoertuig.Prijs = voertuigUpdateDto.Prijs;

            // Voeg de ontbrekende velden toe
            bestaandVoertuig.Huurder = voertuigUpdateDto.Huurder;
            bestaandVoertuig.VerhuurDatum = voertuigUpdateDto.VerhuurDatum;

            await _context.SaveChangesAsync();

            return bestaandVoertuig;
        }
    }
}
