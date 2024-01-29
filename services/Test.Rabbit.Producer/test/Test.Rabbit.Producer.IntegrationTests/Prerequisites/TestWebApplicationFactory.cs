using MassTransit;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Test.Rabbit.Producer.IntegrationTests.Prerequisites.Tests;

namespace Test.Rabbit.Producer.IntegrationTests.Prerequisites;

public class TestWebApplicationFactory<TEntryPoint> : WebApplicationFactory<TEntryPoint> where TEntryPoint : class
{
    public ReloadableLoggerFactory ReloadableLoggerFactory { get; } = new();
    
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureAppConfiguration(ConfigureAppConfiguration);
        
        builder.ConfigureServices(ConfigureServices);
    }

    private void ConfigureAppConfiguration(IConfigurationBuilder configurationBuilder)
    {
        var userName = Environment.UserName;

        configurationBuilder
            .AddJsonFile($"appsettings.Testing.json")
            .AddJsonFile($"appsettings.Testing.local.json", optional: true)
            .AddJsonFile($"appsettings.Testing.{userName}.json", optional: true)
            .AddJsonFile($"appsettings.Testing.{userName}.local.json", optional: true);
    }

    private void ConfigureServices(IServiceCollection services)
    {
        services.AddMassTransitTestHarness();
        
        services.AddSingleton<ILoggerFactory>(ReloadableLoggerFactory);
    }
}