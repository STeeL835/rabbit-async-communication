using Test.Rabbit.Producer.App;
using Test.Rabbit.Producer.WebApi.Features.Mediatr.Behaviors;

namespace Test.Rabbit.Producer.WebApi.Configuration;

public static class MediatrConfigurationExtensions
{
    public static IServiceCollection AddAppMediatr(this IServiceCollection services)
    {
        return services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(AppAssembly.Instance);
            cfg.AddOpenBehavior(typeof(ValidatorBehavior<,>));
        });
    }
}