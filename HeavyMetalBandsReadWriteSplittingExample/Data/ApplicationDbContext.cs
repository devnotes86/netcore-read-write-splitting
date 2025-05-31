using HeavyMetalBandsReadWriteSplittingExample.Models;
using Microsoft.EntityFrameworkCore;

namespace HeavyMetalBandsReadWriteSplittingExample.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<BandDAO> Bands { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
    }
}
