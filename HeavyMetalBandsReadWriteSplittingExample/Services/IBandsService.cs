﻿using HeavyMetalBandsReadWriteSplittingExample.Models;

namespace HeavyMetalBandsReadWriteSplittingExample.Services
{
    public interface IBandsService
    {
        Task<IEnumerable<BandDTO>> GetAllAsync();
        Task<BandDTO> GetByIdAsync(int id);
        Task AddAsync(BandDTO band);
        Task UpdateAsync(BandDTO band);
        Task DeleteAsync(int id);

    }
}
