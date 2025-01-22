using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.ZB;
using backend.Models;

namespace backend.Interfaces
{
    public interface IZBRepository
    {
        Task<List<ZakelijkeBeheerder>> GetAllAsync();

        Task<ZakelijkeBeheerder?> GetByIdAsync(int id);
        Task<ZakelijkeBeheerder> CreateAsync(ZakelijkeBeheerder zBModel);

        Task<ZakelijkeBeheerder?> UpdateAsync(int id, UpdateZBDto zBDto);
        Task<ZakelijkeBeheerder?> DeleteAsync(int id);
    }
}