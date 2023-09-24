using System.Text.Json.Serialization;

namespace Pokedex.pokedata;

public class Icons
{
    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; }

    [JsonPropertyName("front_female")]
    public object FrontFemale { get; set; }
}