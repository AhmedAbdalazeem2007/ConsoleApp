
namespace ConsolePractices;

public class PythonScript
{
    public PythonScript()
    {
        PythonEngine.Initialize();
        using (Py.GIL())
        {
            dynamic np = Py.Import("numpy");
            Console.WriteLine("uyhhuui{0}", np);

        }
    }
}
