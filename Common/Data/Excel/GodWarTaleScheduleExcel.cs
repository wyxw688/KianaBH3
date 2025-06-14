using KianaBH.Data.Config;

namespace KianaBH.Data.Excel;

[ResourceEntity("GodWarTaleSchedule.json")]
public class GodWarTaleScheduleExcel : ExcelResource
{
    public uint TaleScheduleID { get; set; }
    public List<uint> TaleIDList { get; set; } = [];
    public TimestampConfig? BeginTime { get; set; }
    public TimestampConfig? EndTime { get; set; }

    public override int GetId()
    {
        return (int)TaleScheduleID;
    }

    public override void Loaded()
    {
        GameData.GodWarTaleScheduleData.Add(GetId(), this);
    }
}