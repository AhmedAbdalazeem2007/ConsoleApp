

namespace ConsolePractices;

internal class Program
{
    public enum status
    {
        active, noactive
    }
    public async Task print()
    {
        Console.WriteLine("");
    }
    static async Task Main(string[] args)
    { 
        Program program = new Program();
        await Task.Run(() => program.print()
               );
        int product = 7;
        status status = status.active;
        bool l = status.ToString() == "noactive";
        Console.WriteLine(l);
        //dynamic person = new System.Dynamic.ExpandoObject();
        //person.name = "";
        //person.age = 32;
        //person.name = ",mmkmkl";
        //Console.WriteLine(person.name);
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode("data", QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        Bitmap bitmapimage = qrCode.GetGraphic(20);
        string folderPath = @"D:\";
        string fileName = Path.Combine(folderPath, "data" + "_" + "QRCode.png");

        bitmapimage.Save(fileName, ImageFormat.Png);

        //byte[] Bitmaparray = convertBitmaptobytearry(bitmapimage);
        //string url = string.Format("data is {0}", Convert.ToBase64String(Bitmaparray));

        //IFormFile formFile = bitmapimage;

        int num = 90;
        DateTime dateTime =DateTime.Now;
        var pp = dateTime.Date;

        Console.WriteLine(num!);
        if (num is > 90 and < 100)
            Console.WriteLine("oop");
        if (num is > 90 or  < 70)
            Console.WriteLine("oop");

    }
}
