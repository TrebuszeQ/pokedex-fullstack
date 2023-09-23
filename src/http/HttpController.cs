using System.Collections.Immutable;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
// using System.Text.Json;
//
// namespace Pokedex.http;
//
// public class HttpHandler {
//     private HttpClient HttpClient { get; set; }
//     private JsonSerializerOptions options { get; set; }
//     
//     public HttpHandler() {
//         
//         var socketsHandler = new SocketsHttpHandler() {
//             PooledConnectionLifetime = TimeSpan.FromMinutes(2)
//         };
//         HttpClient = new HttpClient(socketsHandler);
//         HttpClient.Timeout = TimeSpan.FromMinutes(2);
//         HttpClient.DefaultRequestHeaders.Accept.Clear();
//         HttpClient.DefaultRequestHeaders.Accept.Add(
//             new MediaTypeWithQualityHeaderValue("application/json"));
//         options = new JsonSerializerOptions {
//             WriteIndented = true,
//             IncludeFields = true,
//             PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
//         };
//     }
//
//
//     private string FormatExceptionMessage(string message)
//     {
//         int index = message.IndexOf(".", StringComparison.Ordinal);
//         message = message.Substring(0, index);
//         return message;
//     }
//     
//     
//     // returns deserialized json response
//     public async Task<Pokemon?> RetPokemonDeserialized(Uri uri)
//     {
//         Pokemon? response;
//         try
//         { 
//             response = await HttpClient.GetFromJsonAsync<Pokemon>(uri, options);
//         }
//         catch (HttpRequestException e)
//         {
//             string formatMess = FormatExceptionMessage(e.Message);
//             Console.WriteLine($"HTTP error occured: {formatMess}.");
//             throw;
//         }
//         return response;
//     }
// }
//
//
//

