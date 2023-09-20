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
    
    
    // returns response from the uri
    public async Task<string> RetStringResponse(Uri uri) {
        HttpClient.DefaultRequestHeaders.Accept.Clear();
        HttpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        string content = await HttpClient.GetStringAsync(uri);
        return content;
    }

    
    // retyrbs response as stream
    public async Task<Stream> RetStreamResponse(Uri uri) {
        HttpClient.DefaultRequestHeaders.Accept.Clear();
        HttpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        Stream content = await HttpClient.GetStreamAsync(uri);
        return content;
    }
}




