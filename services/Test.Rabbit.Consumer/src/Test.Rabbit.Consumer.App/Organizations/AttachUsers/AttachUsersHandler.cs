using MediatR;

namespace Test.Rabbit.Consumer.App.Organizations.AttachUsers;

public class AttachUsersHandler : IRequestHandler<AttachUsersCommand>
{
    public Task Handle(AttachUsersCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}