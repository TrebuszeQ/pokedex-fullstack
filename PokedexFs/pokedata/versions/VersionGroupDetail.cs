using System.Text.Json.Serialization;

namespace Pokedex;

public class VersionGroupDetail
{
    [JsonPropertyName("level_learned_at")]
    public ushort LevelLearnedAt { get; set; }
    [JsonPropertyName("move_learned_method")]
    public MoveLearnMethod MoveLearnMethod { get; set; }
    [JsonPropertyName("version_group")]
    public VersionGroup VersionGroup { get; set; }
}