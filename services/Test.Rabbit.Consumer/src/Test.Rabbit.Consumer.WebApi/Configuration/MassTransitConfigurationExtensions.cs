using System.Reflection;
using MassTransit;

namespace Test.Rabbit.Consumer.WebApi.Configuration;

public static class MassTransitConfigurationExtensions
{
    public static IServiceCollection AddAppMassTransit(this IServiceCollection services)
    {
        return services.AddMassTransit(x =>
        {
            x.AddConsumers(Assembly.GetCallingAssembly());

            x.UsingRabbitMq((context, cfg) =>
            {
                // TODO: move to configuration
                cfg.Host("localhost", "/", h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });

                cfg.ConfigureEndpoints(context);
            });
        });
    }
}