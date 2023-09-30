using Microsoft.Extensions.Logging;
using Test.Rabbit.Producer.App.Users.CreateUser.Parameters;

namespace Test.Rabbit.Producer.App.Users.CreateUser;

public sealed class CreateUserHandler : MediatR.IRequestHandler<CreateUserCommand, CreateUserResponse>
{
    private readonly ILogger<CreateUserHandler> _logger;

    public CreateUserHandler(ILogger<CreateUserHandler> logger)
    {
        _logger = logger;
    }
    
    public Task<CreateUserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}