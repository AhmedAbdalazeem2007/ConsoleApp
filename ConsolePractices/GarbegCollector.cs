
namespace ConsolePractices;

public class GarbegCollector
{
    public GarbegCollector()
    {
        GC.Collect();
        GC.Collect(10);
    }
}