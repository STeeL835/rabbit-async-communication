namespace Test.Rabbit.Producer.App.Users.CreateUser.Contracts;

public sealed record CreateUserCommand(
    string FirstName,
    string LastName,
    string? MiddleName,
    string PhoneNumber,
    string EmailAddress)
    : MediatR.IRequest;