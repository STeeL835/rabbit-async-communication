namespace Test.Rabbit.Producer.Domain.Users;

// TODO: PhoneNumber VO?
public record User(string FirstName, string LastName, string? MiddleName, string PhoneNumber, string Email);
