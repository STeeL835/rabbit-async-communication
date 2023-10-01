namespace Test.Rabbit.Producer.Publishers.CreateUser.TransitContracts;

internal sealed record CreateUserCommand(
    string FirstName,
    string LastName,
    string? MiddleName,
    string PhoneNumber,
    string EmailAddress);