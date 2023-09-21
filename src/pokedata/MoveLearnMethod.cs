using System.Text.Json.Serialization;

namespace Pokedex;

public class MoveLearnMethod
{
    [JsonPropertyName("name")]
    public string name { get; set; }
    [JsonPropertyName("url")]
    public string Url { get; set; }
}