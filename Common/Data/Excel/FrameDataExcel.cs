using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("FrameData.json")]
public class FrameDataExcel : ExcelResource
{
    [JsonPropertyName("id")] public uint Id { get; set; }

    public override int GetId()
    {
        return (int)Id;
    }

    public override void Loaded()
    {
        GameData.FrameData.Add(GetId(), this);
    }
}