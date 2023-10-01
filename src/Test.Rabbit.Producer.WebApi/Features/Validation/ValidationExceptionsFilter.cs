using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Test.Rabbit.Producer.WebApi.Features.Validation;

public sealed class ValidationExceptionsFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is not ValidationException validationException || context.ExceptionHandled) return;

        var propToErrorsMap = validationException.Errors
            .GroupBy(err => err.PropertyName)
            .ToDictionary(
                group => group.Key,
                group => group.Select(err => err.ErrorMessage).ToArray());

        var validationDetails = new ValidationProblemDetails(propToErrorsMap)
        {
            Status = StatusCodes.Status400BadRequest
        };

        context.Result = new ObjectResult(validationDetails)
        {
            StatusCode = StatusCodes.Status400BadRequest
        };
    }
}
