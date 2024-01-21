using AutoMapper;
using MassTransit;
using MediatR;
using Test.Rabbit.Consumer.WebApi.Consumers.CreateUser.Contracts;
using Test.Rabbit.Producer.Publishers.CreateUser.TransitContracts;

namespace Test.Rabbit.Consumer.WebApi.Consumers.CreateUser;

public sealed class CreateUserConsumer : IConsumer<CreateUserCommandDto>
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public CreateUserConsumer(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
    
    public async Task Consume(ConsumeContext<CreateUserCommandDto> context)
    {
        var appCommand = context.Message.ToCommand(_mapper);
        
        await _mediator.Send(appCommand);
    }
}