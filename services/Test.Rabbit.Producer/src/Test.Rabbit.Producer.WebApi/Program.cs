using System.Reflection;
using FluentValidation;
using Test.Rabbit.Producer.App;
using Test.Rabbit.Producer.WebApi.Features.Mediatr.Behaviors;
using Test.Rabbit.Producer.WebApi.Features.Validation;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder.Services);

var app = builder.Build();

ConfigureApplication(app);

app.Run();


void ConfigureServices(IServiceCollection services)
{
    services.AddControllers(cfg => cfg.Filters.Add<ValidationExceptionsFilter>());
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
    
    services.AddAutoMapper(Assembly.GetCallingAssembly());
    services.AddMediatR(cfg =>
    {
        cfg.RegisterServicesFromAssembly(AppAssembly.Instance);
        cfg.AddOpenBehavior(typeof(ValidatorBehavior<,>));
    });
    services.AddValidatorsFromAssembly(AppAssembly.Instance);
}

void ConfigureApplication(WebApplication application)
{
    if (application.Environment.IsDevelopment())
    {
        application.UseSwagger();
        application.UseSwaggerUI();
    }

    application.UseHttpsRedirection();
    application.UseAuthorization();
    application.MapControllers();
}