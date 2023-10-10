using AutoMapper;
using MassTransit;
using Microsoft.Extensions.Logging;
using Test.Rabbit.Producer.Publishers.CreateUser.Contracts;
using Test.Rabbit.Producer.Publishers.CreateUser.TransitContracts;

namespace Test.Rabbit.Producer.Publishers.CreateUser;

public class CreateUserPublisher
{
    private readonly ILogger<CreateUserPublisher> _logger;
    private readonly IMapper _mapper;
    private readonly IBus _bus;

    public CreateUserPublisher(ILogger<CreateUserPublisher> logger, IMapper mapper, IBus bus)
    {
        _logger = logger;
        _mapper = mapper;
        _bus = bus;
    }

    public async Task Publish(CreateUserExternalCommand command, CancellationToken ct)
    {
        var message = _mapper.Map<CreateUserCommandDto>(command);
        
        await _bus.Publish(message, ct); // TODO: make a formatter that doesn't make a topic-queue name from an entity name?
        
        _logger.LogInformation("Published message {@PublishedMessage} to queue {Queue}", message, message.GetType().Name);
    }
}