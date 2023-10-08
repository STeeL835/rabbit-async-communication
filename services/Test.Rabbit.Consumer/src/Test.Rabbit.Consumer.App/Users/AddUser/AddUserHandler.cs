using MediatR;
using Test.Rabbit.Consumer.App.Users.AddUser.Contracts;

namespace Test.Rabbit.Consumer.App.Users.AddUser;

public class AddUserHandler : IRequestHandler<AddUserCommand>
{
    public Task Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}