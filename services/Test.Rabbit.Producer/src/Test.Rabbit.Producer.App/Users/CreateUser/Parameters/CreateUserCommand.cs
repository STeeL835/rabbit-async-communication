namespace Test.Rabbit.Producer.App.Users.CreateUser.Parameters;

public sealed record CreateUserCommand(
    string FirstName,
    string LastName,
    string? MiddleName,
    string PhoneNumber,
    string EmailAddress)
    : MediatR.IRequest<CreateUserResponse>;