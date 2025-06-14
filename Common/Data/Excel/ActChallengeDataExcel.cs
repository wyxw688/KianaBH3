using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("ActChallengeData.json")]
public class ActChallengeDataExcel : ExcelResource
{
    [JsonPropertyName("actId")] public uint ActId { get; set; }
    [JsonPropertyName("difficulty")] public uint Difficulty { get; set; }

    public override int GetId()
    {
        return (int)ActId;
    }

    public override void Loaded()
    {
        if (!GameData.ActChallengeData.ContainsKey(GetId()))
        {
            GameData.ActChallengeData[GetId()] = new List<ActChallengeDataExcel>();
        }
        GameData.ActChallengeData[GetId()].Add(this);
    }
}