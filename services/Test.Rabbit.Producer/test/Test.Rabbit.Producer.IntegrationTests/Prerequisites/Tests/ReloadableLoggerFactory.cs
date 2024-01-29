using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Test.Rabbit.Producer.IntegrationTests.Prerequisites.Tests;

public class ReloadableLoggerFactory : ILoggerFactory
{
    public ILoggerFactory? InnerFactory { get; set; }

    public void Dispose()
    {
        InnerFactory?.Dispose();
    }

    public void AddProvider(ILoggerProvider provider)
    {
        InnerFactory?.AddProvider(provider);
    }

    public ILogger CreateLogger(string categoryName)
    {
        return InnerFactory?.CreateLogger(categoryName)
            ?? NullLogger.Instance;
    }
}