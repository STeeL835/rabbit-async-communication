using MassTransit;

namespace Test.Rabbit.Consumer.WebApi.Consumers.CreateUser;

public class CreateUserConsumerDefinition : ConsumerDefinition<CreateUserConsumer>
{
    protected override void ConfigureConsumer(
        IReceiveEndpointConfigurator endpointConfigurator,
        IConsumerConfigurator<CreateUserConsumer> consumerConfigurator,
        IRegistrationContext context)
    {
        endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
    }
}