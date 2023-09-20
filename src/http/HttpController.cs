using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pokedex.http;

public class HttpHandler {
    private HttpClient HttpClient { get; set; }
    
    public HttpHandler() {
        
        var socketsHandler = new SocketsHttpHandler() {
            PooledConnectionLifetime = TimeSpan.FromMinutes(2)
        };
        HttpClient = new HttpClient(socketsHandler);
        HttpClient.Timeout = TimeSpan.FromMinutes(2);
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

    public async Task<Pokemon?> RetPokemonDeserialized(Uri uri) {
        HttpClient.DefaultRequestHeaders.Accept.Clear();
        HttpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        var response = await HttpClient.GetAsync(uri);
        var json = await response.Content.ReadAsStringAsync();
        var content = JsonSerializer.Deserialize<Pokemon>(json);
        return content;
    }

    public async Task<string?> RetPokemonSerialized(Uri uri)
    {
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };
        var jsonString = JsonSerializer.Serialize(await RetStringResponse(uri), options);
        return jsonString;
    }
}




