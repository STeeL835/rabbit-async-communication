using Test.Rabbit.Consumer.WebApi.Configuration;


var builder = WebApplication.CreateBuilder(args);

var logger = builder.GetLogger<Program>();

try
{
    builder.Host.UseAppSerilog();
    
    ConfigureServices(builder.Services, builder.Configuration);

    var app = builder.Build();

    ConfigureApplication(app);

    app.Run();
}
catch (Exception ex)
{
    logger.LogCritical(ex, "Host terminated unexpectedly");
    throw;
}


void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    services.AddControllers();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();

    services.AddAppDatabase(configuration);
    services.AddAppMediatr();
    services.AddAppAutomapper();
    services.AddAppRabbitMq();
    services.AddAppValidators();
}

void ConfigureApplication(WebApplication webApplication)
{
    if (webApplication.Environment.IsDevelopment())
    {
        webApplication.UseSwagger();
        webApplication.UseSwaggerUI();
    }

    webApplication.UseHttpsRedirection();

    webApplication.UseAuthorization();

    webApplication.MapControllers();
}