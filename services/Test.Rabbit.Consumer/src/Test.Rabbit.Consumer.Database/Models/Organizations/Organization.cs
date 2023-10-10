using Test.Rabbit.Consumer.Database.Models.Users;

namespace Test.Rabbit.Consumer.Database.Models.Organizations;

public sealed class Organization
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }

    public ICollection<User> Users { get; set; }
}