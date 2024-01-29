using Divergic.Logging.Xunit;
using Microsoft.Extensions.Logging;

namespace Test.Rabbit.Producer.IntegrationTests.Prerequisites.Tests;

public class TestLogFormatter : ILogFormatter
{
    public string Format(int scopeLevel, string categoryName, LogLevel logLevel, EventId eventId, string message, Exception? exception)
    {
        var indent = string.Concat(Enumerable.Repeat("| ", scopeLevel));

        return $"{indent}[{ToLevelString(logLevel)}] {GetLastPart(categoryName)}: {message} {exception}";
    }

    private string ToLevelString(LogLevel logLevel)
    {
        return logLevel switch
        {
            LogLevel.Trace => "TRA",
            LogLevel.Debug => "DBG",
            LogLevel.Information => "INF",
            LogLevel.Warning => "WRN",
            LogLevel.Error => "ERR",
            LogLevel.Critical => "CRIT",
            LogLevel.None => "NON",
            _ => throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, null)
        };
    }

    private string GetLastPart(string categoryName) => categoryName.Split('.')[^1];
}