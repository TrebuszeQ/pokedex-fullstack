using System.Text.Json.Serialization;

namespace Pokedex;

public class Stat
{
    // public readonly ushort id { get; }
    [JsonPropertyName("name")]
    public string Name { get; set;  }
    [JsonPropertyName("url")]
    public string Url { get; set; }

    // public Stat(ushort id)
    // {
    //     this.id++;
    // }
}