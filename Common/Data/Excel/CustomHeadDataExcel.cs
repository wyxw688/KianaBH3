using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("CustomHeadData.json")]
public class CustomHeadDataExcel : ExcelResource
{
    [JsonPropertyName("headID")] public uint HeadID { get; set; }

    public override int GetId()
    {
        return (int)HeadID;
    }

    public override void Loaded()
    {
      GameData.CustomHeadData.Add(GetId(), this); 
    }
}