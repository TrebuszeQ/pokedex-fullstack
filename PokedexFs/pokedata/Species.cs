using System.Text.Json.Serialization;

namespace Pokedex;

public class Species
{
// public readonly ushort id { get; }
    [JsonPropertyName("base_hapiness")]
    public ushort BaseHapiness { get; set; }
    [JsonPropertyName("capture_rate")]
    public ushort CaptureRate { get; set; }
    [JsonPropertyName("color")]
    public string Color { get; set; }

    // public Species(ushort id)
    // {
    //     this.id++;
    // }
}