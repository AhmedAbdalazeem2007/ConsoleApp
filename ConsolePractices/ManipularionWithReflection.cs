using System.Reflection;

namespace ConsolePractices;

public class ManipularionWithReflection
{
    public int numop;
    public ManipularionWithReflection()
    {

    }
    public void get()
    {
        var type = typeof(ManipularionWithReflection);
        Console.WriteLine(type);
        Console.WriteLine(type.Name);
        Console.WriteLine(type.Namespace);
        Console.WriteLine(type.FullName);
        Console.WriteLine(type.GetNestedType(""));

        Console.WriteLine(type.IsPublic);
        Console.WriteLine(type.IsAbstract);


        Console.WriteLine(type.BaseType);


        var assemply = type.Assembly;

        Console.WriteLine(assemply.FullName);
        Console.WriteLine(assemply.Location);
        var assemplyname = assemply.GetName();
        Console.WriteLine(assemplyname.Name);
        Console.WriteLine(assemplyname.Version);
        Console.WriteLine(assemplyname.GetPublicKeyToken().Length);

        assemply = Assembly.GetExecutingAssembly();
        Console.WriteLine(assemply.FullName);
        var assemplyes = Assembly.GetEntryAssembly();
        Console.WriteLine(assemplyes);
        var assemplies = Assembly.GetCallingAssembly();
        Console.WriteLine(assemplies);
    }
    public void printAllclasseswithinnamespace<T>(T classexam)
    {
        var type = typeof(T);
        var assemply = type.Assembly;
        var types = assemply.GetTypes();
        foreach (var t in types)
        {
            Console.WriteLine(t.FullName);
        }
    }
    public void printAllmethodswithinclass<T>(T classexam)
    {
        var methods = typeof(T).GetMethods();
        foreach (var m in methods)
        { Console.WriteLine(m.Name); }
    }
    public void printAllpropertyswithinclass<T>(T classexam)
    {
        var properties = typeof(T).GetProperties();
        foreach (var m in properties)
        { Console.WriteLine(m.Name); }
    }
}