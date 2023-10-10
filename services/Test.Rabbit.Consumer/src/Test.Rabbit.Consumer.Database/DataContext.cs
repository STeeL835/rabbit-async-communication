using Microsoft.EntityFrameworkCore;
using Test.Rabbit.Consumer.Database.Models.Organizations;
using Test.Rabbit.Consumer.Database.Models.Users;

namespace Test.Rabbit.Consumer.Database;

public sealed class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options) { }
    
    public DbSet<User> Users => Set<User>();
    public DbSet<Organization> Organizations => Set<Organization>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(DatabaseAssembly.Instance);
    }
}