using Test.Rabbit.Consumer.WebApi.Configuration;


var builder = WebApplication.CreateBuilder(args);

var logger = builder.GetLogger<Program>();

try
{
    builder.AddLocalAndPersonalAppSettings();
    
    builder.Host.UseAppSerilog();
    
    ConfigureServices(builder.Services, builder.Configuration);

    var app = builder.Build();

    await ConfigureApplication(app);

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

async Task ConfigureApplication(WebApplication app)
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();
    
    await app.MigrateDb<Program>();
}