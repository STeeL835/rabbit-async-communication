using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Test.Rabbit.Consumer.WebApi.Configuration;

public static class SerilogConfigurationExtensions
{
    private const string LoggerTemplate = "[{Timestamp:HH:mm:ss} {Level:u3}] {SourceContext} | {Message:lj}{NewLine}{Exception}";

    public static ILogger GetLogger<T>(this WebApplicationBuilder builder)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console(
                outputTemplate:LoggerTemplate,
                theme: AnsiConsoleTheme.Grayscale)
            .CreateBootstrapLogger();
        
        var loggerFactory = new LoggerFactory()
            .AddSerilog(Log.Logger);
        
        return loggerFactory.CreateLogger<T>();
    }
    
    public static IHostBuilder UseAppSerilog(this IHostBuilder host)
    {
        host.UseSerilog((ctx, services, config) =>
        {
            config
                .ReadFrom.Configuration(ctx.Configuration)

                .Enrich.FromLogContext()

                .WriteTo.Console(
                    outputTemplate: LoggerTemplate,
                    theme: AnsiConsoleTheme.Code);
        });

        return host;
    }
}