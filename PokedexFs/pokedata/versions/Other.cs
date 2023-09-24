using System.Text.Json.Serialization;

namespace Pokedex.pokedata;

public class Other
{
    [JsonPropertyName("dream_world")]
    public DreamWorld DreamWorld { get; set; }

    [JsonPropertyName("home")]
    public Home Home { get; set; }

    [JsonPropertyName("official-artwork")]
    public OfficialArtwork OfficialArtwork { get; set; }
}