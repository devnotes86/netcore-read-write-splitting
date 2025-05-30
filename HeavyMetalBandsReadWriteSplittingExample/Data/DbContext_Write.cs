using HeavyMetalBandsReadWriteSplittingExample.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HeavyMetalBandsReadWriteSplittingExample.Data
{
    public class DbContext_Write : DbContext
    {
        public DbContext_Write(DbContextOptions<DbContext_Write> options) : base(options) { }
        public DbSet<Band> Bands { get; set; }
    }
}
