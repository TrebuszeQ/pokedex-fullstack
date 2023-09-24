using System.Text.Json.Serialization;

namespace Pokedex;

public class Moves
{
    [JsonPropertyName("move")] 
    public Move Move { get; set; }
    [JsonPropertyName("version_group_details")]
    public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    
}
