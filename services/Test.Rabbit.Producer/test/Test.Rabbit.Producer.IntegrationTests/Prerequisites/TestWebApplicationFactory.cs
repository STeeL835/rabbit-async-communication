using MassTransit;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Test.Rabbit.Producer.IntegrationTests.Prerequisites;

public class TestWebApplicationFactory<TEntryPoint> : WebApplicationFactory<TEntryPoint> where TEntryPoint : class
{
    // TODO: replace logger with ITestOutputHelper
    
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureAppConfiguration(ConfigureAppConfiguration);
        
        builder.ConfigureServices(ConfigureServices);
    }

    private void ConfigureAppConfiguration(IConfigurationBuilder configurationBuilder)
    {
        var userName = Environment.UserName;

        // TODO: Add configuration like this here and in consumer
        configurationBuilder
            .AddJsonFile($"appsettings.Testing.json", optional: false)
            .AddJsonFile($"appsettings.Testing.local.json")
            .AddJsonFile($"appsettings.Testing.{userName}.json")
            .AddJsonFile($"appsettings.Testing.{userName}.local.json");
    }

    private void ConfigureServices(IServiceCollection services)
    {
        services.AddMassTransitTestHarness();
    }
}