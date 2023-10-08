using Test.Rabbit.Consumer.Domain.Users;

namespace Test.Rabbit.Consumer.App.Users.SearchUsers;

public sealed record SearchUsersResponse(IReadOnlyList<User> Users); // TODO: make App models to decouple domain from presentation entities (immutable VOs I guess are okay, looks into Aggregates more)