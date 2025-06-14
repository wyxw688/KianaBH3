using System.Text.Json.Serialization;
using KianaBH.Data.Config;

namespace KianaBH.Data.Excel;

[ResourceEntity("CityEventPhoto.json")]
public class CityEventPhotoExcel : ExcelResource
{
    public uint PhotoID { get; set; }
    [JsonPropertyName("photoType")] public uint PhotoType { get; set; }

    public override int GetId()
    {
        return (int)PhotoID;
    }

    public override void Loaded()
    {
        GameData.CityEventPhotoData.Add(GetId(), this);
    }
}