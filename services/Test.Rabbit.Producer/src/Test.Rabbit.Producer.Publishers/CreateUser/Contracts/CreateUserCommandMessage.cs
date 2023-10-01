namespace Test.Rabbit.Producer.Publishers.CreateUser.Contracts;

public record CreateUserCommandMessage(
    string FirstName,
    string LastName,
    string? MiddleName,
    string PhoneNumber,
    string EmailAddress);