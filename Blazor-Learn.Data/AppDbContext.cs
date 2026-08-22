using Blazor_Learn.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Learn.Data;

public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    public AppDbContext()
    {
        
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=.\\Databases\\EfTestDatabase.db");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API
        modelBuilder
            .Entity<Customer>()
            .HasIndex(p => p.Name)
            .IsUnique();

        base.OnModelCreating(modelBuilder);
    }
}
