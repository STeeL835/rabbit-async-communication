namespace Test.Rabbit.Producer.WebApi.Controllers.Users.Contracts;

public sealed class CreateUserDto
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string? MiddleName { get; init; }
    public required string PhoneNumber { get; init; }
    public required string EmailAddress { get; init; }
}