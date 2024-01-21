// ReSharper disable once CheckNamespace - MassTransit is blind otherwise
namespace Test.Rabbit.Producer.Publishers.CreateUser.TransitContracts;

public sealed class CreateUserCommandDto
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public string? MiddleName { get; init; }
    public required string PhoneNumber { get; init; }
    public required string EmailAddress { get; init; }
}