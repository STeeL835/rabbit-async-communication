using System.Reflection;

namespace Test.Rabbit.Consumer.Database;

public static class DatabaseAssembly
{
    public static Assembly Instance => Assembly.GetAssembly(typeof(DatabaseAssembly))!;
}