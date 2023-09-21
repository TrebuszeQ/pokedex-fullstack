using System.Text.Json.Serialization;

namespace Pokedex.pokedata.versions;

public class GenerationVii
{
    [JsonPropertyName("icons")]
    public Icons Icons { get; set; }

    [JsonPropertyName("ultra-sun-ultra-moon")]
    public UltraSunUltraMoon UltraSunUltraMoon { get; set; }
}