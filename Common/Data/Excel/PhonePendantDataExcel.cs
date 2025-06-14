using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("PhonePendantData.json")]
public class PhonePendantDataExcel : ExcelResource
{
    public uint PendantId { get; set; }
    public uint Rarity { get; set; }

    public override int GetId()
    {
        return (int)PendantId;
    }

    public override void Loaded()
    {
        GameData.PhonePendantData.Add(GetId(), this);
    }
}