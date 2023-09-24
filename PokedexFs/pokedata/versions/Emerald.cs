using System.Text.Json.Serialization;

namespace Pokedex.http;

public class Emerald
{
    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; }

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; set; }
}