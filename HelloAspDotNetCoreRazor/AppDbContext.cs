using Microsoft.EntityFrameworkCore;

namespace HelloAspDotNetCoreRazor
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
