using System.Reflection;

namespace Test.Rabbit.Producer.App;

// TODO: find a folder for it 
public static class AppAssembly
{
    public static Assembly Instance => Assembly.GetCallingAssembly();
}