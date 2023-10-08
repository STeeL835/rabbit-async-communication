namespace Test.Rabbit.Consumer.Domain.Users;

public sealed record User(
    Guid Id,
    string FirstName,
    string LastName,
    string MiddleName,
    string PhoneNumber,
    string EmailAddress);