
namespace ConsolePractices;

public class QrCodeGenerators
{
    QRCodeGenerator qrCode;
    QRCodeData qrCodeData;
    public QrCodeGenerators()
    {
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode("data", QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        Bitmap bitmapimage = qrCode.GetGraphic(20);
        string folderPath = @"D:\QRCODE";
        string fileName = Path.Combine(folderPath, "data" + "_" + "QRCode.png");

        bitmapimage.Save(fileName, ImageFormat.Png);

        byte[] Bitmaparray = convertBitmaptobytearry(bitmapimage);
        string url = string.Format("data is {0}", Convert.ToBase64String(Bitmaparray));

    }
    public byte[] convertBitmaptobytearry(Bitmap bitmap)
    {
        using (MemoryStream memoryStream = new MemoryStream())
        {
            bitmap.Save(memoryStream, ImageFormat.Png);
            return memoryStream.ToArray();
        }
    }
}