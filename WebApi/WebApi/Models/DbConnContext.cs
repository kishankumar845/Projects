using Microsoft.EntityFrameworkCore;
//using WebApi.Models;

namespace WebApi.Models
{
    public class DbConnContext : DbContext
    {
        public DbConnContext(DbContextOptions<DbConnContext> options) : base(options)
        {
        }
        public DbSet<Register> Register { get; set; }
        public DbSet<EuDetails> euDetails { get; set; }
        public DbSet<RAddress> rAddresses { get; set; }
        public DbSet<PAddress> pAddresses { get; set; }
        public DbSet<OccupationDetails> occupationDetails { get; set; }
        public DbSet<DebitCard> debitCards { get; set; }

    }
}