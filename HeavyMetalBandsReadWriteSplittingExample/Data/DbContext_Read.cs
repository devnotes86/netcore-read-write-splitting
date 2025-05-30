using HeavyMetalBandsReadWriteSplittingExample.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HeavyMetalBandsReadWriteSplittingExample.Data
{
    public class DbContext_Read : DbContext
    {
        public DbContext_Read(DbContextOptions<DbContext_Read> options) : base(options) { }
        public DbSet<Band> Bands { get; set; }
    }
}
