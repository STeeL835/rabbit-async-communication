using Test.Rabbit.Consumer.WebApi.Controllers.Users.Contracts.Search.FiltersParameters;

namespace Test.Rabbit.Consumer.WebApi.Controllers.Users.Contracts.Search;

public class SearchUserFiltersDto
{
    public PaginationParametersDto Pagination { get; init; } = new ();

    public IReadOnlyList<Guid> OrganizationIds { get; init; } = Array.Empty<Guid>();
}