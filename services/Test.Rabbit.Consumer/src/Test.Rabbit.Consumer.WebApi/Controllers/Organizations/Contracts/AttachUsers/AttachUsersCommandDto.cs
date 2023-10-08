namespace Test.Rabbit.Consumer.WebApi.Controllers.Organizations.Contracts.AttachUsers;

public class AttachUsersCommandDto
{
    public required IReadOnlyList<Guid> UserIds { get; init; }
}