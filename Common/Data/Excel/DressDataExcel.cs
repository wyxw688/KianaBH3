using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("DressData.json")]
public class DressDataExcel : ExcelResource
{
    [JsonPropertyName("dressID")] public int DressID { get; set; }
    [JsonPropertyName("avatarIDList")] public List<int> AvatarIDList { get; set; } = [];

    public override int GetId()
    {
        return DressID;
    }

    public override void Loaded()
    {
      GameData.DressData.Add(DressID, this); 
    }
}