using System.Text.Json.Serialization;

namespace Pokedex;

public class Crystal
{
    [JsonPropertyName("back_default")]
    public string BackDefault { get; set; }

    [JsonPropertyName("back_shiny")]
    public string BackShiny { get; set; }

    [JsonPropertyName("back_shiny_transparent")]
    public string BackShinyTransparent { get; set; }

    [JsonPropertyName("back_transparent")]
    public string BackTransparent { get; set; }

    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; }

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; set; }

    [JsonPropertyName("front_shiny_transparent")]
    public string FrontShinyTransparent { get; set; }

    [JsonPropertyName("front_transparent")]
    public string FrontTransparent { get; set; }
}