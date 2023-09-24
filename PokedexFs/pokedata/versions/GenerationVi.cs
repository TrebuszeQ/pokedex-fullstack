using System.Text.Json.Serialization;

namespace Pokedex.pokedata.versions;

public class GenerationVi
{
    [JsonPropertyName("omegaruby-alphasapphire")]
    public OmegarubyAlphasapphire OmegarubyAlphasapphire { get; set; }

    [JsonPropertyName("x-y")]
    public XY XY { get; set; }
}