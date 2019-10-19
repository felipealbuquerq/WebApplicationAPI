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

        public DbSet<User> User { get; set; }
    }
}
