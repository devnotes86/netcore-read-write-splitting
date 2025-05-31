using HeavyMetalBandsReadWriteSplittingExample.Models;

namespace HeavyMetalBandsReadWriteSplittingExample.Repositories
{
    public interface IBandsRepository
    {
        Task<IEnumerable<BandDAO>> GetAllAsync();
        Task<BandDAO> GetByIdAsync(int id);
        Task AddAsync(BandDAO band);
        Task UpdateAsync(BandDAO band);
        Task DeleteAsync(int id);
    }
}
