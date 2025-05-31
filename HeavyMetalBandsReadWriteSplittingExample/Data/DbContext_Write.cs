using HeavyMetalBandsReadWriteSplittingExample.Models;
using Microsoft.EntityFrameworkCore;

namespace HeavyMetalBandsReadWriteSplittingExample.Data
{
    public class DbContext_Write : ApplicationDbContext
    {
        public DbContext_Write(DbContextOptions<DbContext_Write> options) : base(options) { } 
    }
}
