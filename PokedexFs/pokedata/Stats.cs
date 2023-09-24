using System.Text.Json.Serialization;

namespace Pokedex;

public class Stats
{
    // public readonly ushort id { get; }
    [JsonPropertyName("base_stat")]
    public ushort BaseStat { get; set; }
    [JsonPropertyName("effort")]
    public ushort Effort { get; set; }
    [JsonPropertyName("stat")]
    public List<Stat> Stat { get; set; }
    [JsonPropertyName("types")]
    public List<Types> Types { get; set; }

    // public Stats(ushort id)
    // {
    //     this.id++;
    // }
}
