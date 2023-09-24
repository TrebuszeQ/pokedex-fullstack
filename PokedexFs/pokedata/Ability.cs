using System.Text.Json.Serialization;

namespace Pokedex;

public class Ability
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("url")]
    public string Url { get; set; }
}