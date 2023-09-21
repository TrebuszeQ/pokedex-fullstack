using System.Text.Json.Serialization;

namespace Pokedex.pokedata;

public class Version
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; } 
}