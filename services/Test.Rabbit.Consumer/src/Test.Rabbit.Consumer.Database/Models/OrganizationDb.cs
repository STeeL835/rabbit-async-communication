namespace Test.Rabbit.Consumer.Database.Models;

public sealed class OrganizationDb
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }

    public ICollection<UserDb> Users { get; set; }
}