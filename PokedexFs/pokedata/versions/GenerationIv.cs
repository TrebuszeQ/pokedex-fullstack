using System.Text.Json.Serialization;

namespace Pokedex.pokedata.versions;

public class GenerationIv
{
    [JsonPropertyName("diamond-pearl")]
    public DiamondPearl DiamondPearl { get; set; }

    [JsonPropertyName("heartgold-soulsilver")]
    public HeartgoldSoulsilver HeartgoldSoulsilver { get; set; }

    [JsonPropertyName("platinum")]
    public Platinum Platinum { get; set; }
}