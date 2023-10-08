using MediatR;

namespace Test.Rabbit.Consumer.App.Users.AddUser.Contracts;

public sealed record AddUserCommand(
    string FirstName,
    string LastName,
    string MiddleName,
    string PhoneNumber,
    string EmailAddress) : IRequest;