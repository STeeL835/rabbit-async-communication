using Test.Rabbit.Consumer.WebApi.Controllers.Users.Contracts.Search.Filters;

namespace Test.Rabbit.Consumer.WebApi.Controllers.Users.Contracts.Search;

public class SearchUserFiltersDto
{
    public PaginationParameters Pagination { get; init; } = new ();

    public IReadOnlyList<Guid> OrganizationIds { get; init; } = Array.Empty<Guid>();
}