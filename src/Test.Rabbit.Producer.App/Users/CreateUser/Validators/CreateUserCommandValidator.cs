using FluentValidation;
using Test.Rabbit.Producer.App.Users.CreateUser.Parameters;

namespace Test.Rabbit.Producer.App.Users.CreateUser.Validators;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(c => c.MiddleName).NotEmpty().When(command => command.MiddleName is not null);
        RuleFor(c => c.PhoneNumber).NotEmpty();
        RuleFor(c => c.EmailAddress).NotEmpty();
    }
}