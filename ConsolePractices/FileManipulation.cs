using Microsoft.AspNetCore.Http;


namespace ConsolePractices
{
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

        public static FileInfo FileInfo(string path)
        {
            return new System.IO.FileInfo(path);
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
        }
    }
}
