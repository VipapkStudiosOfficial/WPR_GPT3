using backend.Models;

namespace backend.Interfaces
{
    public interface IHuurAanvraagRepository
    {
        Task<IEnumerable<HuurAanvraag>> GetAllAsync();
        Task<HuurAanvraag?> GetByIdAsync(int id);
        Task AddAsync(HuurAanvraag aanvraag);
        Task UpdateAsync(HuurAanvraag aanvraag);
        Task DeleteAsync(int id);
    }
}
