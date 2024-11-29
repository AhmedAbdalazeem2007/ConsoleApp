

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
            AllowTrailingCommas = true,
            DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
            MaxDepth = 64,
            DefaultBufferSize = 4096,
            IgnoreReadOnlyProperties = true,
            //IgnoreWriteOnlyProperties = true,
            PropertyNameCaseInsensitive = true,
            UnknownTypeHandling = JsonUnknownTypeHandling.JsonElement,
            //Converter = null,
            //AllowTrailingCommas = true,
            //UseCamelCase = true,
            //ReadOnlyProperties = JsonReadOnlyPropertyHandling.Ignore,
            //ThrowOnInvalidJson = true,
            //TypeInfoResolver = customResolver,
            NumberHandling = JsonNumberHandling.WriteAsString,
            //AllowComments = true,
            //EnableDynamicObject = true,
            //DateTimeFormat = "yyyy-MM-ddTHH:mm:ss",
            //SkipValidation = true,
            //Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Encodings.Web./*JavaScriptEncoder*/.Default),
          
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            //NumberHandling = JsonNumberHandling.WriteAsString,
            ReadCommentHandling = JsonCommentHandling.Allow,
        };
    }
    public static List<Product> readjson()
    {
        var p = File.ReadAllText("products.json");
        return JsonSerializer.Deserialize<List<Product>>(p);
    }
}