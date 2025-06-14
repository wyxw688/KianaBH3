using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("DressData.json")]
public class DressDataExcel : ExcelResource
{
    [JsonPropertyName("dressID")] public uint DressID { get; set; }
    [JsonPropertyName("avatarIDList")] public List<uint> AvatarIDList { get; set; } = [];

    public override int GetId()
    {
        return (int)DressID;
    }

    public override void Loaded()
    {
      GameData.DressData.Add(GetId(), this); 
    }
}