using System.Reflection;
using FluentValidation;
using Test.Rabbit.Producer.App;
using Test.Rabbit.Producer.Publishers;
using Test.Rabbit.Producer.WebApi.Configuration;
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
    
    services.AddAppAutomapper();
    services.AddAppMediatr();
    services.AddAppValidators();
    services.AddAppRabbitMq();

    services.AddPublishers();
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