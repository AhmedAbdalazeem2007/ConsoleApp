

namespace ConsolePractices;

public static class FileManipulation
{
    public static string pathformat = "D:\\Others\\Articles";// @"D:\Others\Articles" ; @"D:\\Others\ \Articles"
    public static string[] Getdirectories(string path)
    {
        return Directory.GetDirectories(path);
    }
    public static string[] Getfiles(string path)
    {
        return Directory.GetFiles(path);
    }
    public static void readfile(string path)
    {
        using FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read);
        //  filemode (Open, Create, CreateNew, Truncate, Append, or OpenOrCreate), the file access (Read, Write, ReadWrite).
        byte[] buf = new byte[1024];
        int c;
        while ((c = fs.Read(buf, 0, buf.Length)) > 0)
        {
            Console.WriteLine(Encoding.UTF8.GetString(buf, 0, c));
        }
    }
    public static string[] GetDirectoyandfiles(string path)
    {
        return Directory.GetFileSystemEntries(path);
    }
    public static bool is_Directory(string path)
    {
        return Directory.Exists(path);
    }
    public static bool is_File(string path)
    {
        return File.Exists(path);
    }

    public static DirectoryInfo DirectoryInfo(string path)
    {
        return new DirectoryInfo(path);
    }
    public static string curentdir() => Directory.GetCurrentDirectory();

    public static FileInfo FileInfo(string path)
    {
        FileInfo f1 = new System.IO.FileInfo(path);
        var pp = f1.Extension;

        f1.CopyTo("D:ppp.docx");
        print(f1.FullName);
        print(f1.Length.ToString());
        print(f1.CreationTime.ToString());
        print(f1.LastWriteTime.ToString());
        print(f1.LastAccessTime.ToString());
        print(f1.LastWriteTimeUtc.ToString());
        print(f1.Name.ToString());
        print(f1.LinkTarget);
        print(f1.Attributes.ToString());
        print(f1.UnixFileMode.ToString());
        print(f1.Refresh == null ? "dssd" : "DSAds");
        print(f1.CreationTimeUtc.ToString());
        print(f1.IsReadOnly.ToString());
        print(f1.ToString());
        //FileStream file = f1.OpenWrite;

        return f1;
    }
    public static void makedire(string path, string folder)
    {
        path = path + "\\" + folder;
        Directory.CreateDirectory(path);
    }
    public static void deletedireorfile(string path)
    {
        if (Directory.Exists(path))
            Directory.Delete(path);
        else if (File.Exists(path))
            File.Delete(path);
    }
    public static void movedire(string source, string destination)
    {
        Console.WriteLine();
        Directory.Move(source, destination);
    }
    public static void copy(string sourcePath, string destPath)
    {
        File.Copy(sourcePath, destPath);
        Console.WriteLine("file copied");
    }
    public static string GetExtension(IFormFile formFile)
    {
        return Path.GetExtension(formFile.FileName);
    }
    public static string GetDirectoryOfExecutable()
    {
        var executablePath = Assembly.GetExecutingAssembly().Location;
        var baseDirectory = Path.GetDirectoryName(executablePath);
        return baseDirectory;
    }
    public static void printdirinfo(string path)
    {
        var d2 = new DirectoryInfo(path);
        Console.WriteLine("\n\n" + d2.Name);
        Console.WriteLine(d2.FullName);
        Console.WriteLine(d2.Parent);
        Console.WriteLine(d2.Refresh);
        Console.WriteLine(d2.Root);
        Console.WriteLine(d2.Attributes);
        Console.WriteLine(d2.CreationTime);

        Console.WriteLine(d2.LastAccessTime);
        Console.WriteLine(d2.LastWriteTime);
        Console.WriteLine(d2.Name);
        Console.WriteLine(d2.Extension);
        Console.WriteLine(d2.CreationTimeUtc);
        Console.WriteLine(d2.Exists);
        Console.WriteLine(d2.LastWriteTimeUtc + "\n\n\n");
        Console.WriteLine(d2.UnixFileMode);
        Assembly theAssembly = Assembly.Load(new AssemblyName("VectorClass"));
        //Attribute supportsAttribute = theAssembly.GetCustomAttribute(typeof(SupportsWhatsNewAttribute));
        //foreach (Type definedType in theAssembly.ExportedTypes)
        //{
        //    DisplayTypeInfo(definedType);
        //}
    }
    public static void print(string x)
    {
        Console.WriteLine(x);
    }
    //WriteLine(FileManipulation.is_Directory("D:\\القران الكريم\\الشيخ محمدصديق المنشاوى"));
    //    WriteLine(FileManipulation.is_File("D:\\القران الكريم\\الشيخ محمدصديق المنشاوى\\036.mp3"));
     
}
