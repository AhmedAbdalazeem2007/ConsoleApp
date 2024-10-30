
namespace ConsolePractices;

public class ExceptionManipulation
{
    public ExceptionManipulation()
    {
        
    }
    public void printException()
    {

        int num1 = 3, num2 = 0;
        try
        {
            num1 /= num2;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("12");
            /*throw*/
            ;
        }
        catch (NullReferenceException op)
        {
            Console.WriteLine("rgkdfgfd");
        }
        //catch
        //{
        //    Console.WriteLine("34");
        //}
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            Console.WriteLine("23");
        }
    }
}
