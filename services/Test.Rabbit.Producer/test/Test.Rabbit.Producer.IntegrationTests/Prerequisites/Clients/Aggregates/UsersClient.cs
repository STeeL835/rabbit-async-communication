using System.Net.Http.Json;
using Test.Rabbit.Producer.WebApi.Controllers.Users.Contracts.CreateUser;

namespace Test.Rabbit.Producer.IntegrationTests.Prerequisites;

internal class UsersClient(HttpClient client)
{
    public async Task<HttpResponseMessage> CreateUserRaw(CreateUserDto createUser)
    {
        return await client.PostAsJsonAsync("/users", createUser);
    }
}