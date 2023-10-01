namespace Test.Rabbit.Producer.Publishers.CreateUser.Contracts;

public sealed record CreateUserExternalCommand(
    string FirstName,
    string LastName,
    string? MiddleName,
    string PhoneNumber,
    string EmailAddress);