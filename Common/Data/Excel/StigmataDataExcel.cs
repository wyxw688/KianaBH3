using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("StigmataData.json")]
public class StigmataDataExcel : ExcelResource
{
    public int ID { get; set; }
    [JsonPropertyName("maxLv")] public int MaxLv { get; set; }
    [JsonPropertyName("rarity")] public int Rarity { get; set; }
    [JsonPropertyName("maxRarity")] public int MaxRarity { get; set; }
    [JsonPropertyName("evoID")] public int EvoID { get; set; }
    [JsonPropertyName("quality")] public int Quality { get; set; }
    [JsonPropertyName("isSecurityProtect")] public bool IsSecurityProtect { get; set; }
    [JsonPropertyName("protect")] public bool Protect { get; set; }

    public override int GetId()
    {
        return ID;
    }

    public override void Loaded()
    {
        GameData.StigmataData.Add(ID, this);
    }
}