using MassTransit.Testing;
using Test.Rabbit.Producer.IntegrationTests.Prerequisites.Clients;
using Test.Rabbit.Producer.IntegrationTests.Prerequisites.Mocks;

namespace Test.Rabbit.Producer.IntegrationTests.Prerequisites;

public class TestFixture
{
    public TestWebApplicationFactory<Program> AppFactory { get; }
    
    public ExternalServiceMocks ExternalServices { get; }
    public ControllerClients Controllers { get; }
    public ITestHarness TestHarness { get; } // TODO: reset harness for each test
    
    
    public TestFixture()
    {
        AppFactory = new TestWebApplicationFactory<Program>();

        var client = AppFactory.CreateClient();

        ExternalServices = new ExternalServiceMocks();
        Controllers = new ControllerClients(client);
        TestHarness = AppFactory.Services.GetTestHarness();

        TestHarness.Start(); // it doesn't say much in the docs, just shows it like "duh"
    }
}