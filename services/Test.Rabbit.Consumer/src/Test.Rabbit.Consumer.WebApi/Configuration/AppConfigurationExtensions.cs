namespace Test.Rabbit.Consumer.WebApi.Configuration;

public static class AppConfigurationExtensions
{
    public static IHostApplicationBuilder AddLocalAndPersonalAppSettings(this IHostApplicationBuilder hostBuilder)
    {
        var environmentName = hostBuilder.Environment.EnvironmentName;
        var username = Environment.UserName;
        
        hostBuilder.Configuration.AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true);
        hostBuilder.Configuration.AddJsonFile($"appsettings.{environmentName}.local.json", optional: true, reloadOnChange: true);
        
        hostBuilder.Configuration.AddJsonFile($"appsettings.{username}.json", optional: true, reloadOnChange: true);
        hostBuilder.Configuration.AddJsonFile($"appsettings.{environmentName}.{username}.json", optional: true, reloadOnChange: true);

        return hostBuilder;
    }
}