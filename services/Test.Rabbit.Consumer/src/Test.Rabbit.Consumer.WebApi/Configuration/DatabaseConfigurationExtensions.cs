using Microsoft.EntityFrameworkCore;
using Test.Rabbit.Consumer.Database;

namespace Test.Rabbit.Consumer.WebApi.Configuration;

public static class DatabaseConfigurationExtensions
{
    public static IServiceCollection AddAppDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        return services.AddDbContext<DataContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("Default")));

    }
}