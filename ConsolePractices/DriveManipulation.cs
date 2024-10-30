
namespace ConsolePractices;

public static class DriveManipulation
{
    public static string DriveName = "E://";
    public static DriveInfo Driveinfo(string path)
    {
        return new DriveInfo(path);
    }
    public static DriveInfo[] Getdrivess()
    {
        return DriveInfo.GetDrives();
    }
    public static void printdriveinfo(string path)
    {
        var d1 = new DriveInfo(path);
        Console.WriteLine("\n\n" + d1.Name);
        Console.WriteLine(d1.Name);
        Console.WriteLine(d1.Name);
        Console.WriteLine(d1.TotalSize);
        Console.WriteLine(d1.IsReady);
        Console.WriteLine(d1.VolumeLabel);
        Console.WriteLine(d1.AvailableFreeSpace);
        Console.WriteLine(d1.DriveFormat);// NTF 
        Console.WriteLine(d1.DriveType);
        Console.WriteLine(d1.GetType());
    }
}
