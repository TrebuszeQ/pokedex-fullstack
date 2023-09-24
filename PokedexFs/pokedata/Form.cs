using System.Text.Json.Serialization;

namespace Pokedex;

public class Form
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("url")]
    public string Url { get; set; }
}