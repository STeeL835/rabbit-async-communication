namespace Test.Rabbit.Consumer.WebApi.Controllers.Contracts.Entities.Users;

public sealed class UserDto
{
    public Guid Id { get; init; }
    public Guid? OrganizationId { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public string? MiddleName { get; init; }
    public required string PhoneNumber { get; init; }
    public required string EmailAddress { get; init; }
}