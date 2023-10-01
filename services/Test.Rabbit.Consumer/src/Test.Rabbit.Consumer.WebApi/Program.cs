using Test.Rabbit.Consumer.WebApi.Configuration;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();

ConfigureApplication(app);

app.Run();


void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    services.AddControllers();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();

    services.AddAppDatabase(configuration);
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