using FluentValidation;
using Test.Rabbit.Consumer.App;

namespace Test.Rabbit.Consumer.WebApi.Configuration;

public static class FluentValidationConfigurationExtensions
{
    public static IServiceCollection AddAppValidators(this IServiceCollection services)
    {
        return services.AddValidatorsFromAssembly(AppAssembly.Instance);
    }
}