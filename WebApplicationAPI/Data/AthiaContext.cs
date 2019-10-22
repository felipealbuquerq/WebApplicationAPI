using Microsoft.EntityFrameworkCore;

namespace WebApplicationAPI.Data
{
    using Models;

    public class AthiaContext : DbContext
    {
        public AthiaContext (DbContextOptions<AthiaContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<AddressUser> AddressesUser { get; set; }
    }
}
