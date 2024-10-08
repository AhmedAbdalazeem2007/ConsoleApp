
using System.Text.Json.Serialization;
using System.Text.Json;
namespace ConsolePractices;

public class Json2Text
{
    public Json2Text()
    {

    }
    public static void config()
    {
        JsonSerializerOptions options = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true,
            MaxDepth = 64,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            NumberHandling = JsonNumberHandling.WriteAsString,
            ReadCommentHandling = JsonCommentHandling.Allow,
        };

    }
    public static List<Product> readjson()
    {
        var p = File.ReadAllText("products.json");
        return JsonSerializer.Deserialize<List<Product>>(p);
    }
}