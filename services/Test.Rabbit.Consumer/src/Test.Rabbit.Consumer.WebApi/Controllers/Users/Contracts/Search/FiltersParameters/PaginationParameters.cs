namespace Test.Rabbit.Consumer.WebApi.Controllers.Users.Contracts.Search.Filters;

public class PaginationParameters
{
    public int Skip { get; init; } = 0;
    public int Take { get; init; } = 20;
}