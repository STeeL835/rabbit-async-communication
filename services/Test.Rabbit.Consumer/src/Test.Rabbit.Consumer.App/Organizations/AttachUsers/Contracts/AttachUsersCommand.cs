using MediatR;

namespace Test.Rabbit.Consumer.App.Organizations.AttachUsers.Contracts;

public sealed record AttachUsersCommand(Guid OrganizationId, IReadOnlyList<Guid> UserIds) : IRequest;