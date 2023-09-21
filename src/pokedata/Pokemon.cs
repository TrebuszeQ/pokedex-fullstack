using System.Text.Json.Serialization;
using Pokedex.pokedata;

namespace Pokedex;

public class Pokemon
{
    [JsonPropertyName("abilities")]
    public List<Abilities> Abilities { get; set; }
    [JsonPropertyName("base_experience")]
    public ushort BaseExperience { get; set; }
    [JsonPropertyName("forms")]
    public List<Form> Forms { get; set; }
    [JsonPropertyName("game_indices")]
    public List<GameIndex>? GameIndices { get; set; }
    [JsonPropertyName("height")]
    public ushort Height { get; set; }
    [JsonPropertyName("held_items")]
    public List<HeldItem>? HeldItems { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("is_default")]
    public bool IsDefault { get; set; }
    [JsonPropertyName("encounters")]
    public string? Encounters { get; set; }
    [JsonPropertyName("moves")]
    public List<Moves> Moves { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("order")]
    public ushort Order { get; set; }
    [JsonPropertyName("past_types")]
    public List<object>? PastTypes { get; set; }
    [JsonPropertyName("species")]
    public Species Species { get; set; }
    [JsonPropertyName("sprites")]
    public Sprites Sprites { get; set; }
    [JsonPropertyName("stats")]
    public List<Stat> Stats { get; set; }
    [JsonPropertyName("weight")]
    public ushort Weight { get; set; }
}