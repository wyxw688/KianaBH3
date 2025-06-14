using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("MaterialData.json")]
public class MaterialDataExcel : ExcelResource
{
    [JsonPropertyName("ID")]  public int Id { get; set; }
    [JsonPropertyName("rarity")] public int Rarity { get; set; }
    [JsonPropertyName("maxRarity")] public int MaxRarity { get; set; }
    [JsonPropertyName("quantityLimit")] public int QuantityLimit { get; set; }

    public override int GetId()
    {
        return Id;
    }

    public override void Loaded()
    {
        GameData.MaterialData.Add(Id, this);
    }
}