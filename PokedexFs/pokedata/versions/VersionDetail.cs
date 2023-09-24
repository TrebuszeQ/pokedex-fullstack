using System.Text.Json.Serialization;

namespace Pokedex.pokedata;

public class VersionDetail
{
    [JsonPropertyName("rarity")]
    public int? Rarity { get; set; }

    [JsonPropertyName("version")]
    public Version Version { get; set; }
}