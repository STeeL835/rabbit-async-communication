using FluentValidation;
using MediatR;

namespace Test.Rabbit.Consumer.WebApi.Features.Mediatr.Behaviors;

public class ValidatorBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    // can be many, can be none
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidatorBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        foreach (var validator in _validators)
        {
            await validator.ValidateAndThrowAsync(request, cancellationToken);
        }

        var response = await next();

        return response;
    }
}