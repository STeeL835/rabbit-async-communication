using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Test.Rabbit.Consumer.Database;

/// <summary> For migration creation </summary>
public sealed class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var connectionString =
            "Username=postgres;Password=password;Host=localhost;Port=5432;Database=test-rabbit-consumer";

        var optionsBuilder = new DbContextOptionsBuilder<DataContext>().UseNpgsql(connectionString).Options;
        
        return new DataContext(optionsBuilder);
    }
}