using System.Text.Json.Serialization;

namespace Pokedex;

public class DiamondPearl
{
    [JsonPropertyName("back_default")]
    public string BackDefault { get; set; }

    [JsonPropertyName("back_female")]
    public object BackFemale { get; set; }

    [JsonPropertyName("back_shiny")]
    public string BackShiny { get; set; }

    [JsonPropertyName("back_shiny_female")]
    public object BackShinyFemale { get; set; }

    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; }

    [JsonPropertyName("front_female")]
    public object FrontFemale { get; set; }

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; set; }

    [JsonPropertyName("front_shiny_female")]
    public object FrontShinyFemale { get; set; }
}