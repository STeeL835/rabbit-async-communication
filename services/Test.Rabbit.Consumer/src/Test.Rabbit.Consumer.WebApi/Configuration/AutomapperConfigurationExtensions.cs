using System.Reflection;
using Test.Rabbit.Consumer.App;

namespace Test.Rabbit.Consumer.WebApi.Configuration;

public static class AutomapperConfigurationExtensions
{
    public static IServiceCollection AddAppAutomapper(this IServiceCollection services)
    {
        return services.AddAutoMapper(Assembly.GetCallingAssembly(), AppAssembly.Instance);
    }
}