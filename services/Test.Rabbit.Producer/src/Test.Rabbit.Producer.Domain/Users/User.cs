namespace Test.Rabbit.Producer.Domain.Users;

// TODO: PhoneNumber VO?
public record User(
    Guid Id,
    string FirstName,
    string LastName,
    string? MiddleName,
    string PhoneNumber,
    string EmailAddress);
