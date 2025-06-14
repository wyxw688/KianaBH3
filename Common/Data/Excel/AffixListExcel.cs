using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("AffixList.json")]
public class AffixListExcel : ExcelResource
{
    [JsonPropertyName("affixID")] public int AffixID { get; set; }
    [JsonPropertyName("level")]  public int Level { get; set; }

    public override int GetId()
    {
        return AffixID;
    }

    public override void Loaded()
    {
        GameData.AffixListData.Add(AffixID, this);
    }
}