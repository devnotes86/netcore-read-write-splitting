using HeavyMetalBandsReadWriteSplittingExample.Models;
using HeavyMetalBandsReadWriteSplittingExample.Repositories;

namespace HeavyMetalBandsReadWriteSplittingExample.Services
{
  
    public class BandsService: IBandsService
    {
        private readonly IBandsRepository _bandsRepository;

        public BandsService(IBandsRepository bandRepository)
        {
            _bandsRepository = bandRepository;
        }

        public async Task<IEnumerable<BandDTO>> GetAllAsync()
        {
            var bands = await _bandsRepository.GetAllAsync();
            var bandDTOs = bands.Select(band => new BandDTO { Id = band.id, BandName = band.band_name, YearCreated = band.year_created });
            return bandDTOs.ToList();
        }

        public async Task<BandDTO> GetByIdAsync(int id)
        {
            var band = await _bandsRepository.GetByIdAsync(id);
            return new BandDTO { Id = band.id, BandName = band.band_name, YearCreated = band.year_created };
        }

        public async Task AddAsync(BandDTO dto)
        {
            var dao = new BandDAO { band_name = dto.BandName, year_created = dto.YearCreated };
            await _bandsRepository.AddAsync(dao);
        }

        public async Task UpdateAsync(BandDTO dto)
        {
            var dao = new BandDAO { id = dto.Id, band_name = dto.BandName, year_created = dto.YearCreated };
            await _bandsRepository.UpdateAsync(dao);
        }

        public async Task DeleteAsync(int id) => await _bandsRepository.DeleteAsync(id);
    }
}
