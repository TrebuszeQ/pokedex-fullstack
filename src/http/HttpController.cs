using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace Pokedex.http;

public class HttpHandler {
    private HttpClient HttpClient { get; set; }
    
    public HttpHandler() {
        
        var socketsHandler = new SocketsHttpHandler() {
            PooledConnectionLifetime = TimeSpan.FromMinutes(2)
        };
        HttpClient = new HttpClient(socketsHandler);
        HttpClient.Timeout = TimeSpan.FromMinutes(2);
        HttpClient.DefaultRequestHeaders.Accept.Clear();
        HttpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };
    }
    
    
    // returns response from the uri
    public async Task<string> RetStringResponse(Uri uri) {
        HttpClient.DefaultRequestHeaders.Accept.Clear();
        HttpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        string content = await HttpClient.GetStringAsync(uri);
        return content;
    }

    
    // returns response as stream
    public async Task<Stream> RetStreamResponse(Uri uri) {
        HttpClient.DefaultRequestHeaders.Accept.Clear();
        HttpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        Stream content = await HttpClient.GetStreamAsync(uri);
        return content;
    }

    
    // returns deserialized json
    public async Task<Pokemon?> RetPokemonDeserialized(Uri uri)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true,

        };
        
        var response = await HttpClient.GetAsync(uri);
        var json = await response.Content.ReadAsStringAsync();
        // Console.WriteLine(json);
        var content = JsonSerializer.Deserialize<Pokemon>(json);
        return content;
    }

    public async Task<Pokemon?> RetPokemonDeserialized2(Uri uri)
    {
        Pokemon? response = await HttpClient.GetFromJsonAsync<Pokemon>(uri);
        return response;
    }
}




