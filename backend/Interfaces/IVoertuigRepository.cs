using System.Collections.Generic;
using System.Threading.Tasks;
using backend.Dtos.Voertuig;
using backend.Models;

namespace backend.Interfaces
{
    public interface IVoertuigRepository
    {
        Task<List<Voertuig>> GetAllAsync();
        Task<Voertuig?> GetByIdAsync(int id); // Specificeer het geretourneerde type als Voertuig
        Task<Voertuig> CreateVoertuigAsync(Voertuig voertuig);
        Task<Voertuig?> UpdateAsync(int id, VoertuigUpdateDto voertuigUpdateDto); // Verander 'object' naar 'Voertuig'
        Task<Voertuig?> DeleteAsync(int id);
    }
}
