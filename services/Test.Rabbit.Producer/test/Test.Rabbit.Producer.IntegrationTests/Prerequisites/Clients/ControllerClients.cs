using Test.Rabbit.Producer.IntegrationTests.Prerequisites.Clients.Aggregates;

namespace Test.Rabbit.Producer.IntegrationTests.Prerequisites.Clients;

public class ControllerClients(HttpClient client)
{
    public UsersClient Users => new (client);
}