using Test.Rabbit.Producer.IntegrationTests.Prerequisites.Clients.Implementations;

namespace Test.Rabbit.Producer.IntegrationTests.Prerequisites.Clients;

public class ControllerClients(HttpClient client)
{
    public UsersClient Users => new (client);
}