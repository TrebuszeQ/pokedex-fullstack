using System.Text.Json.Serialization;
using Pokedex.http;

namespace Pokedex.pokedata.versions;

public class GenerationIii
{
    [JsonPropertyName("emerald")]
    public Emerald Emerald { get; set; }

    [JsonPropertyName("firered-leafgreen")]
    public FireredLeafGreen FireredLeafgreen { get; set; }

    [JsonPropertyName("ruby-sapphire")]
    public RubySapphire RubySapphire { get; set; }
}