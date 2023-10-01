using Test.Rabbit.Consumer.Database.Models.Organizations;

namespace Test.Rabbit.Consumer.Database.Models.Users;

public sealed class UserDb
{
    public required Guid Id { get; set; }
    public Guid? OrganizationId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName { get; set; }
    public required string PhoneNumber { get; set; }
    public required string EmailAddress { get; set; }

    public OrganizationDb? Organization { get; set; }
}