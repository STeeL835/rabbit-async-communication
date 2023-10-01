using MassTransit;

namespace Test.Rabbit.Producer.WebApi.Configuration;

public static class RabbitMqConfigurationExtensions
{
    public static IServiceCollection AddAppRabbitMq(this IServiceCollection services)
    {
        return services.AddMassTransit(x =>
        {
            x.SetKebabCaseEndpointNameFormatter();
            
            x.UsingRabbitMq((context,cfg) =>
            {
                // TODO: move to configuration
                cfg.Host("localhost", "/", h => {
                    h.Username("guest");
                    h.Password("guest");
                });

                cfg.ConfigureEndpoints(context);
            });
        });

    }
}