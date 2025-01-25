using backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Interfaces
{
    public interface ISchadeRepository
    {
        Task<List<Schade>> GetAllAsync();
        Task<Schade> GetByIdAsync(int id);
        Task CreateAsync(Schade schade);
        Task UpdateAsync(Schade schade);
        Task DeleteAsync(int id);
    }
}
