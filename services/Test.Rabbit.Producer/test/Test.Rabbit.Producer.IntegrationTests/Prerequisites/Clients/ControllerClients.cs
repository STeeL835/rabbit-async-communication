namespace Test.Rabbit.Producer.IntegrationTests.Prerequisites;

internal class ControllerClients(HttpClient client)
{
    public UsersClient Users => new UsersClient(client);
}