using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.Klant;


namespace backend.Interfaces
{
    public interface IPHRepository
    {
        Task<List<ParticuliereHuurder>> GetAllAsync();

        Task<ParticuliereHuurder?> GetByIdAsync(int id);
        Task<ParticuliereHuurder> CreateAsync(ParticuliereHuurder PHModel);

        Task<ParticuliereHuurder?> UpdateAsync(int id, UpdatePHDto PHDto);
        Task<ParticuliereHuurder?> DeleteAsync(int id);
    }
}