using Blazor_Learn.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Learn.Data
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
