using System.Text.Json.Serialization;

namespace Pokedex;

public struct Types
{
    // public readonly ushort id { get; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("url")]
    public string Url { get; set; }

    // public Types(ushort id)
    // {
    //     this.id++;
    // }
}