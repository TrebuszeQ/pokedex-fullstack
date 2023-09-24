using System.Text.Json.Serialization;
using Pokedex.pokedata.versions;

namespace Pokedex;

public class GenerationI
{
    [JsonPropertyName("red-blue")]
    public RedBlue RedBlue { get; set; }

    [JsonPropertyName("yellow")]
    public Yellow Yellow { get; set; }
}