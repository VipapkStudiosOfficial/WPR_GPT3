using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Dtos.Klant;
using backend.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
    public class PHRepository : IPHRepository
    {
        private readonly ApplicationDBContext _context;
        public PHRepository(ApplicationDBContext context){
            _context = context;
        }

        public async Task<ParticuliereHuurder> CreateAsync(ParticuliereHuurder pHModel)
        {
            await _context.ParticuliereHuurders.AddAsync(pHModel);
            await _context.SaveChangesAsync();
            return pHModel;
        }

        public async Task<ParticuliereHuurder?> DeleteAsync(int id)
        {
            var pHModel = await _context.ParticuliereHuurders.FirstOrDefaultAsync(x => x.PHId == id);
            if(pHModel == null){
                return null;
            }
            _context.ParticuliereHuurders.Remove(pHModel);
            await _context.SaveChangesAsync();
            return pHModel;
        }

        public async Task<List<ParticuliereHuurder>> GetAllAsync()
        {
            return await _context.ParticuliereHuurders.ToListAsync();
        }

        public async Task<ParticuliereHuurder?> GetByIdAsync(int id)
        {
            return await _context.ParticuliereHuurders.FindAsync(id);
        }

        public async Task<ParticuliereHuurder?> UpdateAsync(int id, UpdatePHDto pHDto)
        {
            var existingPH = await _context.ParticuliereHuurders.FirstOrDefaultAsync(x => x.PHId == id);

            if(existingPH == null){
                return null;
            }
            existingPH.Naam = pHDto.Naam;
            existingPH.Adres = pHDto.Adres;

            await _context.SaveChangesAsync();

            return existingPH;
        }
    }
}