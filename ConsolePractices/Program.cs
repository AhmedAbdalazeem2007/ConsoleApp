
namespace ConsolePractices;
public sealed record Studentt
{
    public Studentt()
    {

    }
    public Studentt(Studentt studentt)
    {
        this.Id=studentt.Id;
        this.Name=studentt.Name;
    }
    public Studentt(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
    public int Id { get;  }
    public string Name { get; }
}
internal class Program
{
    enum Grad
    {
        A=1, B=2, C=3, D=4, E=5, F=6,
    }

    public async Task print()
    {
        WriteLine("");
    }
    private static int Run(string[] args)
    {
        if (!TryParseArguments(args, out var cli))
        {
            return 1;
        }

        var searchResult = ExecuteSearch(cli.Input, cli.Patterns, cli.Sync);
        WriteOutputFile(searchResult, cli.Output);
        return 0;
    }

    private static void WriteOutputFile(IEnumerable<SearchResult> result, string path)
    {
        Console.WriteLine("Writing result to " + Path.GetFullPath(path));
        using (var writer = new StreamWriter(path, false, Encoding.UTF8))
        {
            writer.WriteLine("sep=,");
            SearchResult.WriteCsvHeader(writer);
            foreach (var item in result)
            {
                item.WriteCsv(writer);
            }
        }
    }

    private static IEnumerable<SearchResult> ExecuteSearch(string[] input, string[] patterns, bool sync)
    {
        // See: https://referencesource.microsoft.com/#System.Core/System/Linq/Parallel/Scheduling/Scheduling.cs,df4daefa7f756d38,references
        var cpuCount = sync ? 1 : Math.Min(512, Environment.ProcessorCount);

        var inputFiles =
            from directory in input.AsParallel().WithDegreeOfParallelism(cpuCount)
            from pattern in patterns
            from path in Directory.EnumerateFiles(directory, pattern, SearchOption.AllDirectories)
            select path;

        var filesByProvider =
            from path in inputFiles
            group path by SearchProvider.ByPath(path) into filesByProviderGroup
            where filesByProviderGroup.Key != null
            select new { provider = filesByProviderGroup.Key, files = filesByProviderGroup };

        var searchResults =
            from item in filesByProvider
            from result in item.provider.Run(item.files)
            let normalizedPath = Path.GetFullPath(result.Path ?? ".").ToLowerInvariant()
            orderby normalizedPath, result.StartIndex
            select result;

        return searchResults;
    }

    private static bool TryParseArguments(string[] args, out CliArguments result)
    {
        result.Input = new[] { Environment.CurrentDirectory };
        result.Output = "result.csv";
        result.Patterns = new[] { "*.*" };
        result.Sync = false;

        bool printUsage = args.Select(item => item.ToLowerInvariant()).Intersect(new[] { "-h", "--help", "/help", "/?" }).Any();
        if (printUsage)
        {
            Console.Error.WriteLine("Usage:");
        }

        foreach (var arg in args)
        {
            var match = arg.ToLowerInvariant();

            var knownArgument = TryMatchArray("input", ref result.Input, "Input directories")
                             || TryMatchParameter("output", ref result.Output, "Output file (.csv)")
                             || TryMatchArray("patterns", ref result.Patterns, "Included file patterns")
                             || TryMatchFlag("sync", ref result.Sync, "Synchronized or parallel execution");

            if (printUsage)
            {
                break;
            }

            if (!knownArgument)
            {
                Console.Error.WriteLine("Invalid argument: " + arg);
            }

            bool TryMatchFlag(string name, ref bool parameter, string description)
            {
                if (printUsage && description != null)
                {
                    Console.Error.WriteLine($"\t--{name}");
                    Console.Error.WriteLine($"\t\t{description}");
                    Console.Error.WriteLine("\t\tDefault: " + parameter);
                    return false;
                }

                if (match == "--" + name)
                {
                    parameter = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool TryMatchParameter(string name, ref string parameter, string description)
            {
                if (printUsage && description != null)
                {
                    Console.Error.WriteLine($"\t--{name}=<value>");
                    Console.Error.WriteLine($"\t\t{description}");
                    Console.Error.WriteLine("\t\tDefault: " + parameter);
                    return false;
                }

                var prefix = "--" + name + "=";
                if (match.StartsWith(prefix))
                {
                    parameter = arg.Substring(prefix.Length);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool TryMatchArray(string name, ref string[] array, string description)
            {
                if (printUsage && description != null)
                {
                    Console.Error.WriteLine($"\t--{name}=<value1,value2,...>");
                    Console.Error.WriteLine($"\t\t{description}");
                    Console.Error.WriteLine("\t\tDefault: " + string.Join(",", array));
                    return false;
                }

                string parameter = null;
                if (!TryMatchParameter(name, ref parameter, null))
                {
                    return false;
                }

                array = parameter
                    .Split(new[] { ',' })
                    .Select(item => item.Trim())
                    .Where(item => !string.IsNullOrEmpty(item))
                    .ToArray();

                return true;
            }
        }

        return !printUsage;
    }

    private struct CliArguments
    {
        public string[] Input;
        public string Output;
        public string[] Patterns;
        public bool Sync;
    }
    private static void InitListener(IEnumerable<EventSource> sources)
    {
        var listener = new Eampleclass();
        foreach (var source in sources)
        {
            listener.EnableEvents(source, EventLevel.LogAlways);
        }
    }
    static async Task Main(string[] args)
    {
        Studentt studentt = new Studentt(2, "");
        Studentt studentt1 = new Studentt(studentt);
        Console.WriteLine(studentt1.Id);

        string dateString = "304-11-2024";
        DateTime? time=null;

        //DateTime dateTime = time.Value;
        Console.WriteLine(time.Value);
        //string format = "MM-dd-yyyy hh:mm tt";
        //Console.WriteLine(DateTime.Now.ToString(format));
        //string dateString = "30-11-2024";
        //DateTime dateTime;
        //if (DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
        //{
        //    Console.WriteLine("Parsed DateTime: " + dateTime);
        //}
        //Grad grad = Grad.A;
        //grad = (Grad)78;
        //Console.WriteLine(grad);
        //WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));  // Output: 2024-08-18 15:30:45

        DateTime date1 = new DateTime(2024, 11, 20, 10, 30, 0);
        DateTime date2 = new DateTime(2024, 11, 20, 3, 45, 0);

        // استخراج الأوقات فقط
        TimeSpan time1 = date1.TimeOfDay;
        TimeSpan time2 = date2.TimeOfDay;
        // جمع الأوقات
        TimeSpan totalTime = time1 + time2;

        // إضافة الزمن المجموع إلى يوم معين
        DateTime result = date1.Date.Add(totalTime);

        Console.WriteLine(result);

        //Eampleclass eampleclass = Eampleclass.OOp;
        //for (int i = 0; i < 4; i++)
        //{
        //    eampleclass = Eampleclass.OOp;
        //    Console.WriteLine(eampleclass.Name);

        //    eampleclass.Name = "hello";
        //    Console.WriteLine(eampleclass.Name);
        //}
        //textWriter.WriteLine("oop");
        //object num1 = 90;
        //if(num1 is int number)
        //{
        //    Console.WriteLine();
        //}
        //Eampleclass eampleclass = new Eampleclass();


        //IEnumerable<EventSource> eventSources = EventSource.GetSources();
        //InitListener(eventSources);

        //var p = Debugger.IsAttached;
        //Console.WriteLine(p);
        //string ? x = "9iu";
        //int? num = null;
        //Console.WriteLine(string.IsNullOrEmpty(x));
        //Console.WriteLine(num.HasValue);
        //for (int i = 0; i <= 255; i++)
        //{
        //    char ch = (char)i;
        //    string dec=i.ToString().PadLeft(3, '0');
        //}
        //int num = 14;
        //Console.WriteLine(num.ToString().PadLeft(4, '0'));
        //string p= Convert.ToString(num, 2);
        //Console.WriteLine($"{p,-12}");

        //List<Person> list=null;
        //Console.WriteLine(list.Any());
        //var pp = list.DistinctBy(p => p.age).DistinctBy(pp => pp.name).ToList();
        //foreach (var i in pp)
        //{
        //    Console.WriteLine(i.name);
        //    Console.WriteLine(i.age);
        //}

        //int p = (int)Grad.A;

        //Program program = new Program();
        //await Task.Run(() => program.print()
        //       );
        //int[] A = new int[7];
        //if (A.Length is > 6 and < 9)
        //    WriteLine("jk");
        //dynamic person = new System.Dynamic.ExpandoObject();
        //person.name = "";
        //person.age = 32;
        //person.name = ",mmkmkl";
        //Console.WriteLine(person.name);
        //QRCodeGenerator qrGenerator = new QRCodeGenerator();
        //QRCodeData qrCodeData = qrGenerator.CreateQrCode("data", QRCodeGenerator.ECCLevel.Q);
        //QRCode qrCode = new QRCode(qrCodeData);
        //Bitmap bitmapimage = qrCode.GetGraphic(20);
        //string folderPath = @"D:\";
        //string fileName = Path.Combine(folderPath, "data" + "_" + "QRCode.png");

        //bitmapimage.Save(fileName, ImageFormat.Png);

        //byte[] Bitmaparray = convertBitmaptobytearry(bitmapimage);
        //string url = string.Format("data is {0}", Convert.ToBase64String(Bitmaparray));

        //IFormFile formFile = bitmapimage;
        //Console.WriteLine(Directory.GetCurrentDirectory());
    }
}