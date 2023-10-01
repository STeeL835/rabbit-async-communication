using Microsoft.Extensions.DependencyInjection;
using Test.Rabbit.Producer.Publishers.CreateUser;

namespace Test.Rabbit.Producer.Publishers;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPublishers(this IServiceCollection services)
    {
        return services.AddTransient<CreateUserPublisher>();
    }
}