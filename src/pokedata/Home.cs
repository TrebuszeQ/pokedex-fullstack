using System.Text.Json.Serialization;

namespace Pokedex.pokedata;

public class Home
{
    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; }

    [JsonPropertyName("front_female")]
    public object FrontFemale { get; set; }

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; set; }

    [JsonPropertyName("front_shiny_female")]
    public object FrontShinyFemale { get; set; }
}