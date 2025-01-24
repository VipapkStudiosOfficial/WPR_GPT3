using backend.Data;
using backend.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
    public class HuurAanvraagRepository : IHuurAanvraagRepository
    {
        private readonly ApplicationDBContext _context;

        public HuurAanvraagRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HuurAanvraag>> GetAllAsync()
        {
            return await _context.HuurAanvragen.ToListAsync();
        }

        public async Task<HuurAanvraag?> GetByIdAsync(int id)
        {
            return await _context.HuurAanvragen.FindAsync(id);
        }

        public async Task AddAsync(HuurAanvraag aanvraag)
        {
            await _context.HuurAanvragen.AddAsync(aanvraag);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(HuurAanvraag aanvraag)
        {
            _context.HuurAanvragen.Update(aanvraag);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var aanvraag = await _context.HuurAanvragen.FindAsync(id);
            if (aanvraag != null)
            {
                _context.HuurAanvragen.Remove(aanvraag);
                await _context.SaveChangesAsync();
            }
        }
    }
}
