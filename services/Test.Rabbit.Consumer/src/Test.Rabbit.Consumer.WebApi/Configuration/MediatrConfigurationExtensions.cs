using Test.Rabbit.Consumer.App;
using Test.Rabbit.Consumer.WebApi.Features.Mediatr.Behaviors;

namespace Test.Rabbit.Consumer.WebApi.Configuration;

public static class MediatrConfigurationExtensions
{
    public static IServiceCollection AddAppMediatr(this IServiceCollection services)
    {
        return services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(AppAssembly.Instance); // TODO: Should this be in App assembly or here's okay?
            cfg.AddOpenBehavior(typeof(ValidatorBehavior<,>));
        });
    }
}