
using System;

namespace ConsolePractices;

public class ClassDetails
{
    public void printallClasswiththeassembly()
    {
        var assemply = typeof(StringManipulation).Assembly;
        Console.WriteLine(assemply.FullName);
        var types = assemply.GetTypes();
        foreach (var type in types)
        {
            Console.WriteLine(type.FullName);
        }
    }
    public void printallmethodswiththeclass()
    {
        var methods = typeof(StringManipulation).GetMethods();
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
    public void printallproperties()
    {
        var p = typeof(StringManipulation).GetProperties();
        foreach (var p2 in p)
        {
            Console.WriteLine(p2.Name);
        }
    }
}
