using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("StageData_Main.json")]
public class StageDataMainExcel : ExcelResource
{
    [JsonPropertyName("levelId")] public uint LevelId { get; set; }
    [JsonPropertyName("maxProgress")] public uint MaxProgress { get; set; }
    [JsonPropertyName("challengeList")] public List<ChallengeData> ChallengeList { get; set; } = [];

    public override int GetId()
    {
        return (int)LevelId;
    }

    public override void Loaded()
    {
        GameData.StageDataMain.Add(GetId(), this);
    }
}


public class ChallengeData
{
    [JsonPropertyName("challengeId")] public uint ChallengeId { get; set; }
    [JsonPropertyName("rewardId")] public uint RewardId { get; set; }
}