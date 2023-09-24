using System.Text.Json.Serialization;

namespace Pokedex.pokedata;

public class OfficialArtwork
{
    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; }

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; set; }
}