using System.Text.Json.Serialization;

namespace Pokedex.pokedata.versions;

public class GenerationViii
{
    [JsonPropertyName("icons")]
    public Icons Icons { get; set; }
}