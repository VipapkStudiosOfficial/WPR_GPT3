using backend.Data;
using backend.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Repository
{
    public class SchadeRepository : ISchadeRepository
    {
        private readonly ApplicationDBContext _context;

        public SchadeRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Schade>> GetAllAsync()
        {
            return await _context.Schades // Correcte tabelnaam
                .Include(s => s.Voertuig) // Zorg ervoor dat het Voertuig wordt geladen
                .ToListAsync();
        }

        public async Task<Schade> GetByIdAsync(int id)
        {
            return await _context.Schades // Correcte tabelnaam
                .Include(s => s.Voertuig) // Zorg ervoor dat het Voertuig wordt geladen
                .FirstOrDefaultAsync(s => s.SchadeId == id);
        }

        public async Task CreateAsync(Schade schade)
        {
            await _context.Schades.AddAsync(schade); // Correcte tabelnaam
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Schade schade)
        {
            _context.Schades.Update(schade); // Correcte tabelnaam
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var schade = await GetByIdAsync(id);
            if (schade != null)
            {
                _context.Schades.Remove(schade); // Correcte tabelnaam
                await _context.SaveChangesAsync();
            }
        }
    }
}
