using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Pokedex;

public class Abilities {
    [JsonPropertyName("ability")]
    public Ability Ability { get; set; }
    [JsonPropertyName("is_hidden")]
    public bool IsHidden { get; set; }
    [JsonPropertyName("Slot")]
    public ushort Slot { get; set; }
}