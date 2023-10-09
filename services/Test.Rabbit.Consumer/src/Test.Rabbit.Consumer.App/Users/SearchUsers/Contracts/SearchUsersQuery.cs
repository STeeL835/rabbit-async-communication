using MediatR;
using Test.Rabbit.Consumer.App.Contracts;

namespace Test.Rabbit.Consumer.App.Users.SearchUsers.Contracts;

public sealed record SearchUsersQuery(
    PaginationParameters Pagination,
    IReadOnlyList<Guid> OrganizationIds) : IRequest<SearchUsersResponse>;