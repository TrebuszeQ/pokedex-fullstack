using System.Text.Json.Serialization;

namespace Pokedex.pokedata.versions;

public class GenerationV
{
    [JsonPropertyName("black-white")]
    public BlackWhite BlackWhite { get; set; }
}