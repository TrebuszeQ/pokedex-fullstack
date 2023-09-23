using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace Pokedex.http;


//lazy singleton
public sealed class HttpHandlerLazy
{
    private static Lazy<HttpHandlerLazy> instance { get; } = new (
        () => new HttpHandlerLazy());

    public static HttpHandlerLazy Instance => instance.Value;
    private JsonSerializerOptions options { get; }
    static readonly HttpClient HttpClient = new ();

    private HttpHandlerLazy()
    {
        HttpClient.Timeout = TimeSpan.FromMinutes(1);
        HttpClient.DefaultRequestHeaders.Accept.Clear();
        HttpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        options = new JsonSerializerOptions {
            WriteIndented = true,
            IncludeFields = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };
    }

    private string FormatExceptionMessage(string message)
    {
        int index = message.IndexOf(".", StringComparison.Ordinal);
        message = message.Substring(0, index);
        return message;
    }
    
    
    // returns deserialized json response
    public async Task<Pokemon?> RetPokemonDeserialized(Uri uri)
    {
        Pokemon? response;
        try
        {
            response = await HttpClient.GetFromJsonAsync<Pokemon>(uri, options);
        }
        catch (HttpRequestException e)
        {
            string formatMess = FormatExceptionMessage(e.Message);
            Console.WriteLine($"HTTP error occured: {formatMess}.");
            throw;
        }
        return response;
    }
}




