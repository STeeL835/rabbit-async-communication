using Microsoft.EntityFrameworkCore;
using Test.Rabbit.Consumer.Database;

var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder.Services);

var app = builder.Build();

ConfigureApplication(app);

app.Run();


void ConfigureServices(IServiceCollection services)
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    
    builder.Services.AddDbContext<DataContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));
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