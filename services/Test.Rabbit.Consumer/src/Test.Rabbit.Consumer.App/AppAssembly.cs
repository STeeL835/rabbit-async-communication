using System.Reflection;

namespace Test.Rabbit.Consumer.App;

public static class AppAssembly
{
    public static Assembly Instance => Assembly.GetAssembly(typeof(AppAssembly))!;
}