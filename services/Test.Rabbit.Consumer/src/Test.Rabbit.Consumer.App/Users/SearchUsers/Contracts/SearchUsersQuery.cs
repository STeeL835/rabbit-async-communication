using MediatR;

namespace Test.Rabbit.Consumer.App.Users.SearchUsers.Contracts;

public sealed record SearchUsersQuery(
    PaginationParameters Pagination,
    IReadOnlyList<Guid> OrganizationIds) : IRequest<SearchUsersResponse>;