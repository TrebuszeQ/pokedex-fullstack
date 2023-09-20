using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Pokedex;

public class Abilities {
    [JsonPropertyName("Ability")]
    public Ability Ability { get; set; }
    [JsonPropertyName("IdHidden")]
    public bool IsHidden { get; set; }
    [JsonPropertyName("Slot")]
    public ushort Slot { get; set; }
}