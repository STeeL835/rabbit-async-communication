using FluentValidation;
using Test.Rabbit.Producer.App;

namespace Test.Rabbit.Producer.WebApi.Configuration;

public static class FluentValidationConfigurationExtensions
{
    public static IServiceCollection AddAppValidators(this IServiceCollection services)
    {
        return services.AddValidatorsFromAssembly(AppAssembly.Instance);
    }
}