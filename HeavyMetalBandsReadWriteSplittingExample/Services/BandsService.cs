using HeavyMetalBandsReadWriteSplittingExample.Data;
using HeavyMetalBandsReadWriteSplittingExample.Data.Models;
using HeavyMetalBandsReadWriteSplittingExample.Models;
using Microsoft.EntityFrameworkCore;

namespace HeavyMetalBandsReadWriteSplittingExample.Services
{
  
    public class BandsService: IBandsService
    {
        private readonly DbContext_Write _writeDb;
        private readonly DbContext_Read _readDb;

        public BandsService(DbContext_Write writeDb, DbContext_Read readDb)
        {
            _writeDb = writeDb;
            _readDb = readDb;
        }

        public async Task<List<Band>> GetBandsAsync()
        {
            return await _readDb.Bands.ToListAsync();
        }

        public async Task<int> AddBandAsync(BandCreateRequest band)
        {
            var bandToAdd = new Band
            {
                band_name = band.BandName,
                year_created = band.Year
            };


            _writeDb.Bands.Add(bandToAdd);
            await _writeDb.SaveChangesAsync();

            return bandToAdd.id;
        }
    }
}
