

namespace ConsolePractices;

internal class StringManipulation
{
    public StringManipulation()
    {
        
    }
    public string muultiline = @"
this is
multiline
";
    public string muli = """

this is
multiline
""";
    public void printdecimalnumber(double num)
    {
        num = 987654.321d;
        WriteLine(num.ToString(".00")); //Output to the hundreth decimal place
        WriteLine(num.ToString("0"));   //Output is an integer
        WriteLine(num.ToString("C"));
    }
}
