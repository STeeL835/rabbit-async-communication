namespace Test.Rabbit.Consumer.WebApi.Controllers.Contracts;

public class PaginationParametersDto
{
    public int Skip { get; init; } = 0;
    public int Take { get; init; } = 20;
}