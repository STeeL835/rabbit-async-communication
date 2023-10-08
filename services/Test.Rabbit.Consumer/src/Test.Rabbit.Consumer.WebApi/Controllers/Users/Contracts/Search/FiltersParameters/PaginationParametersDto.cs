namespace Test.Rabbit.Consumer.WebApi.Controllers.Users.Contracts.Search.FiltersParameters;

public class PaginationParametersDto
{
    public int Skip { get; init; } = 0;
    public int Take { get; init; } = 20;
}