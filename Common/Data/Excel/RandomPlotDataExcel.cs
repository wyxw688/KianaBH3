using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("RandomPlotData.json")]
public class RandomPlotDataExcel : ExcelResource
{
    [JsonPropertyName("plotId")] public uint PlotId { get; set; }
    [JsonPropertyName("startDialogId")] public uint StartDialogId { get; set; }
    [JsonPropertyName("finishDialogIdList")] public List<uint> FinishDialogIdList { get; set; } = [];

    public override int GetId()
    {
        return (int)PlotId;
    }

    public override void Loaded()
    {
        GameData.RandomPlotData.Add(GetId(), this);
    }
}