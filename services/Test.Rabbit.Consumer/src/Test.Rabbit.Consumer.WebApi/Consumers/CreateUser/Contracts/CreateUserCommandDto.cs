namespace Test.Rabbit.Consumer.WebApi.Consumers.CreateUser.Contracts;

public sealed class CreateUserCommandDto
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public string? MiddleName { get; init; }
    public required string PhoneNumber { get; init; }
    public required string EmailAddress { get; init; }
}