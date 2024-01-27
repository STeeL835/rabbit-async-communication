namespace Test.Rabbit.Producer.IntegrationTests.Prerequisites;

internal class TestFixture
{
    public TestWebApplicationFactory<Program> AppFactory { get; }
    public ExternalServiceMocks ExternalServices { get; }
    public HttpClient Client { get; }
    public ControllerClients Controllers { get; }
    
    
    public TestFixture(TestWebApplicationFactory<Program> appFactory)
    {
        AppFactory = appFactory;

        ExternalServices = new ExternalServiceMocks();
        
        Client = AppFactory.CreateClient();
        Controllers = new ControllerClients(Client);
    }
}