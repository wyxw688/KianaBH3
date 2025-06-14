namespace KianaBH.Data.Excel;

[ResourceEntity("RecommendPanel.json")]
public class RecommendPanelExcel : ExcelResource
{
    public uint PanelId { get; set; }

    public override int GetId()
    {
        return (int)PanelId;
    }

    public override void Loaded()
    {
        GameData.RecommendPanelData.Add(GetId(), this);
    }
}