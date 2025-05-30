using HeavyMetalBandsReadWriteSplittingExample.Data.Models;
using HeavyMetalBandsReadWriteSplittingExample.Models;

namespace HeavyMetalBandsReadWriteSplittingExample.Services
{
    public interface IBandsService
    {
        Task<List<Band>> GetBandsAsync();
        Task<int> AddBandAsync(BandCreateRequest band);

    }
}
