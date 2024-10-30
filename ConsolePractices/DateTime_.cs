

namespace ConsolePractices;

public class DateTime_
{
    public static void oop()
    {
        string dateString_ = "2024-08-01";
        string dateString = "01-08-2024";
        dateString = "yyyy-MM-dd HH:mm:ss";  // Output: 2024-08-18 15:30:45
        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");  // Output: 2024-08-18 15:30:45
        string pattern = "MMMM dd, yyyy hh:mm tt";  // Output: August 18, 2024 03:30 PM
        string pattern_ = "MMMM dd, yyyy hh:mm tt";
        string format = "dd-MM-yyyy";
        DateTime date = new DateTime(2024, 8, 1, 14, 30, 0);
        DateTime dateTime;
        if (DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
        {
            Console.WriteLine("Parsed DateTime: " + dateTime);
        }
        else
        {
            Console.WriteLine("Invalid date format.");
        }
        List<string> list = new List<string> { "hello", "jjj" };
        TimeSpan timeSpan = new TimeSpan();
        //TimeSpan.TryParse()
        /*
           DateOnly
          string dateString = "09-04-2000";
          string format = "dd-MM-yyyy";
          DateOnly dateTime;
          if (DateOnly.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
          {
              Console.WriteLine("Parsed DateTime: " + dateTime);
          }
          */

    }

}