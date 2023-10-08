using MediatR;
using Test.Rabbit.Consumer.App.Users.SearchUsers.Contracts;

namespace Test.Rabbit.Consumer.App.Users.SearchUsers;

public sealed record SearchUsersQuery(
    PaginationParameters Pagination,
    IReadOnlyList<Guid> OrganizationIds) : IRequest<SearchUsersResponse>;