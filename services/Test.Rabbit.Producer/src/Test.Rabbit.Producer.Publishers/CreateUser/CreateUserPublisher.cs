using MassTransit;
using Test.Rabbit.Producer.Publishers.CreateUser.Contracts;

namespace Test.Rabbit.Producer.Publishers.CreateUser;

public class CreateUserPublisher
{
    private readonly IBus _bus;

    public CreateUserPublisher(IBus bus)
    {
        _bus = bus;
    }

    public async Task Publish(CreateUserCommandMessage message, CancellationToken ct)
    {
        await _bus.Publish(message, ct);
    }
}