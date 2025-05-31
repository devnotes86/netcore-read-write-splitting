using HeavyMetalBandsReadWriteSplittingExample.Models;
using Microsoft.EntityFrameworkCore;

namespace HeavyMetalBandsReadWriteSplittingExample.Data
{
    public class DbContext_Read : ApplicationDbContext
    {
        public DbContext_Read(DbContextOptions<DbContext_Read> options) : base(options) { } 
    }
}
