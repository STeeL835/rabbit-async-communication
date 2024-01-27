namespace Test.Rabbit.Producer.WebApi.Configuration;

public static class AppConfigurationExtensions
{
    public static IHostApplicationBuilder AddLocalAndPersonalAppSettings(this IHostApplicationBuilder hostBuilder)
    {
        var environmentName = hostBuilder.Environment.EnvironmentName;
        var username = Environment.UserName;

        // TODO: name for local appsettings, but for everyone in repo AND invisible for app running in cloud
        hostBuilder.Configuration.AddJsonFile($"appsettings.{username}.json", optional: true, reloadOnChange: true);
        hostBuilder.Configuration.AddJsonFile($"appsettings.{environmentName}.{username}.json", optional: true, reloadOnChange: true);
        
        hostBuilder.Configuration.AddJsonFile($"appsettings.local.json", optional: true, reloadOnChange: true);
        hostBuilder.Configuration.AddJsonFile($"appsettings.{environmentName}.local.json", optional: true, reloadOnChange: true);
        hostBuilder.Configuration.AddJsonFile($"appsettings.{environmentName}.{username}.local.json", optional: true, reloadOnChange: true);

        return hostBuilder;
    }
}