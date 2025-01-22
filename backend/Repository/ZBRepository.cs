using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Dtos.ZB;
using backend.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
    public class ZBRepository : IZBRepository
    {
        private readonly ApplicationDBContext _context;
        public ZBRepository(ApplicationDBContext context){
            _context = context;
        }

        public async Task<ZakelijkeBeheerder> CreateAsync(ZakelijkeBeheerder zBModel)
        {
            await _context.ZakelijkeBeheerders.AddAsync(zBModel);
            await _context.SaveChangesAsync();
            return zBModel;
        }

        public async Task<ZakelijkeBeheerder?> DeleteAsync(int id)
        {
            var zBModel = await _context.ZakelijkeBeheerders.FirstOrDefaultAsync(x => x.ZBId == id);
            if(zBModel == null){
                return null;
            }
            _context.ZakelijkeBeheerders.Remove(zBModel);
            await _context.SaveChangesAsync();
            return zBModel;
        }

        public async Task<List<ZakelijkeBeheerder>> GetAllAsync()
        {
            return await _context.ZakelijkeBeheerders.ToListAsync();
        }

        public async Task<ZakelijkeBeheerder?> GetByIdAsync(int id)
        {
            return await _context.ZakelijkeBeheerders.FindAsync(id);
        }

        public async Task<ZakelijkeBeheerder?> UpdateAsync(int id, UpdateZBDto zBDto)
        {
            var existingZB = await _context.ZakelijkeBeheerders.FirstOrDefaultAsync(x => x.ZBId == id);

            if(existingZB == null){
                return null;
            }
            existingZB.BedrijfsNaam = zBDto.BedrijfsNaam;
            existingZB.Adres = zBDto.Adres;
            existingZB.KvKNummer = zBDto.KvKNummer;

            await _context.SaveChangesAsync();

            return existingZB;
        }
    }
}