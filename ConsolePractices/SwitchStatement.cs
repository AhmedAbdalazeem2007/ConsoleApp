
namespace ConsolePractices;

public class SwitchStatement
{
    public SwitchStatement()
    {

    }
    public void print(int num)
    {
        switch (num)
        {
            case 0:
                Console.WriteLine("o");
                break;
            case 1:
            case 2:
                Console.WriteLine("1 or 2");
                break;
            case 3:
                Console.WriteLine("4");
                goto case 1;
            default:
                Console.WriteLine("no invalid");
                break;
        }
    }
}
