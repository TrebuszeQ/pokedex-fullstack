using System.Net.Http.Headers;
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
    }
    
    
    // serializes JSON
    private string DeserializeBasic(string jsonString) {
        string deserialized = JsonSerializer.Deserialize<string>(jsonString);
        if (deserialized != null) return deserialized;
        return ("Empty entry");
    }
    
    
    // returns response from the uri
    public async Task<string> RetResponse(Uri uri) {
        HttpClient.DefaultRequestHeaders.Accept.Clear();
        HttpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        string content = await HttpClient.GetStringAsync(uri);
        return DeserializeBasic(content);
    }
}




