using System.Reflection;
using Test.Rabbit.Producer.App;

namespace Test.Rabbit.Producer.WebApi.Configuration;

public static class AutomapperConfigurationExtensions
{
    public static IServiceCollection AddAppAutomapper(this IServiceCollection services)
    {
        return services.AddAutoMapper(Assembly.GetCallingAssembly(), AppAssembly.Instance);
    }
}