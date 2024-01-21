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

    public static async Task<WebApplication> MigrateDb<TLogger>(this WebApplication app)
    {
        using var serviceScope = app.Services.CreateScope();
        
        await using var ctx = serviceScope.ServiceProvider.GetRequiredService<DataContext>();
        var logger = serviceScope.ServiceProvider.GetRequiredService<ILogger<TLogger>>();

        var pendingMigrations = (await ctx.Database.GetPendingMigrationsAsync()).ToList();

        if (pendingMigrations.Count > 0)
        {
            logger.LogInformation("Applying pending database migrations");
            
            await ctx.Database.MigrateAsync();
        }

        return app;
    }
}