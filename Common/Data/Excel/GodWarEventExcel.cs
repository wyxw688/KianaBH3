namespace KianaBH.Data.Excel;

[ResourceEntity("GodWarEvent.json")]
public class GodWarEventExcel : ExcelResource
{
    public uint EventID { get; set; }
    public int EventType { get; set; }
    public List<uint> ParamsVar { get; set; } = [];


    public override int GetId()
    {
        return (int)EventID;
    }

    public override void Loaded()
    {
        GameData.GodWarEventData.Add(GetId(), this);
    }
}