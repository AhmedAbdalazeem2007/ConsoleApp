namespace ConsolePractices;

internal class Program
{
    static void Main(string[] args)
    {
        StringManipulation stringManipulation = new StringManipulation();
        ManipularionWithReflection manipularionWithReflection = new ManipularionWithReflection();
        manipularionWithReflection.printAllclasseswithinnamespace(stringManipulation);
        manipularionWithReflection.printAllmethodswithinclass(manipularionWithReflection);
        manipularionWithReflection.printAllpropertyswithinclass(manipularionWithReflection);
        int num = 90;
        Console.WriteLine(num!);
        if (num is > 90 and < 100)
            Console.WriteLine("oop");
        if (num is > 90 or < 70)
            Console.WriteLine("oop");

    }
}
