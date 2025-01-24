using backend.Interfaces;
using backend.Models;

namespace backend.Service
{
    public class HuurAanvraagService : IHuurAanvraagService
    {
        private readonly IHuurAanvraagRepository _repository;

        public HuurAanvraagService(IHuurAanvraagRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<HuurAanvraag>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<HuurAanvraag?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task ApproveAsync(int id)
        {
            var aanvraag = await _repository.GetByIdAsync(id);
            if (aanvraag != null)
            {
                aanvraag.Status = "Approved";
                await _repository.UpdateAsync(aanvraag);
            }
        }

        public async Task RejectAsync(int id, string reason)
        {
            var aanvraag = await _repository.GetByIdAsync(id);
            if (aanvraag != null)
            {
                aanvraag.Status = "Rejected";
                aanvraag.RejectReason = reason;
                await _repository.UpdateAsync(aanvraag);
            }
        }
    }
}
