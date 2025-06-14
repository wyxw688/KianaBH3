namespace KianaBH.Data.Excel;

[ResourceEntity("GodWarTalentData.json")]
public class GodWarTalentDataExcel : ExcelResource
{
    public uint TalentID { get; set; }
    public uint MaxLevel { get; set; }
    public List<uint> TaleIDList { get; set; } = [];

    public override int GetId()
    {
        return (int)TalentID;
    }

    public override void Loaded()
    {
        GameData.GodWarTalentData.Add(GetId(), this);
    }
}