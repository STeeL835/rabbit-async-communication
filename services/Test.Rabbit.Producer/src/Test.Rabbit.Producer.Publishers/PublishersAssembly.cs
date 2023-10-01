using System.Reflection;

namespace Test.Rabbit.Producer.Publishers;

public static class PublishersAssembly
{
    public static Assembly Instance => Assembly.GetAssembly(typeof(PublishersAssembly))!;
}