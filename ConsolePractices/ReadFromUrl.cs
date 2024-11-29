
namespace ConsolePractices;

public class ReadFromUrl
{
    public async Task<string> Read(string url)
    {
        HttpClient httpClient = new();
        var respons = await httpClient.GetAsync(url);
        respons.EnsureSuccessStatusCode();
        return await respons.Content.ReadAsStringAsync();
    }
}
