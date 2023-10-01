using AutoMapper;
using MediatR;
using Test.Rabbit.Producer.App.Users.CreateUser.Contracts;
using Test.Rabbit.Producer.Publishers.CreateUser;
using Test.Rabbit.Producer.Publishers.CreateUser.Contracts;

namespace Test.Rabbit.Producer.App.Users.CreateUser;

public sealed class CreateUserHandler : IRequestHandler<CreateUserCommand>
{
    private readonly IMapper _mapper;
    private readonly CreateUserPublisher _publisher;

    public CreateUserHandler(IMapper mapper, CreateUserPublisher publisher)
    {
        _mapper = mapper;
        _publisher = publisher;
    }
    
    public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var externalCommand = _mapper.Map<CreateUserExternalCommand>(request); // hmm
        
        await _publisher.Publish(externalCommand, cancellationToken);
    }
}