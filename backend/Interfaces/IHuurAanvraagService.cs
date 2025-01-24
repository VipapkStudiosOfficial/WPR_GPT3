using backend.Models;

namespace backend.Interfaces
{
    public interface IHuurAanvraagService
    {
        Task<IEnumerable<HuurAanvraag>> GetAllAsync();
        Task<HuurAanvraag?> GetByIdAsync(int id);
        Task ApproveAsync(int id);
        Task RejectAsync(int id, string reason);
    }
}
