using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("TutorialData.json")]
public class TutorialDataExcel : ExcelResource
{
    [JsonPropertyName("id")] public uint Id { get; set; }
    [JsonPropertyName("index")] public uint Index { get; set; }

    public override int GetId()
    {
        return (int)Id;
    }

    public override void Loaded()
    {
        GameData.TutorialData.Add(GetId(), this);
    }
}