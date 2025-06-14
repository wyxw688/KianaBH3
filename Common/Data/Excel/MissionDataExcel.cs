using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("MissionData.json")]
public class MissionDataExcel : ExcelResource
{
    [JsonPropertyName("id")] public uint Id { get; set; }
    [JsonPropertyName("totalProgress")] public uint TotalProgress { get; set; }
    public uint Priority { get; set; }
    

    public override int GetId()
    {
        return (int)Id;
    }

    public override void Loaded()
    {
        GameData.MissionData.Add(GetId(), this);
    }
}