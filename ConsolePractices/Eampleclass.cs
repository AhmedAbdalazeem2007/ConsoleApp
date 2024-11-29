
global using System.Diagnostics.Tracing;
using FluentAssertions;

namespace ConsolePractices;

public class Eampleclass: EventListener
{
    private static readonly Lazy<Eampleclass> _eampleclass = new Lazy<Eampleclass>
        (() => new Eampleclass());
    public string Name {  get; set; }
    public static Eampleclass OOp
    {
        get
        {
            return _eampleclass.Value;
        }
        set
        {

        }
    }
    public Eampleclass()
    {
        
    }
    public override void Dispose()
    {
        this.Dispose();
    }
    protected override void OnEventSourceCreated(EventSource eventSource)
    {
        Console.WriteLine(eventSource.Guid);
        //base.OnEventSourceCreated(eventSource);
    }
    protected override void OnEventWritten(EventWrittenEventArgs eventData)
    {
        foreach (var payload in eventData.Payload)
        {
            Console.WriteLine($"\t{payload}");
        }
        base.OnEventWritten(eventData);
    }
}
