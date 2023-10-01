using Microsoft.EntityFrameworkCore;
using Test.Rabbit.Consumer.Database.Models;

namespace Test.Rabbit.Consumer.Database;

public sealed class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options) { }
    
    public DbSet<UserDb> Users => Set<UserDb>();
    public DbSet<OrganizationDb> Organizations => Set<OrganizationDb>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}