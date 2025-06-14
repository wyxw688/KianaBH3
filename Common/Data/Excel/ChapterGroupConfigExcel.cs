using KianaBH.Data.Config;

namespace KianaBH.Data.Excel;

[ResourceEntity("ChapterGroupConfig.json")]
public class ChapterGroupConfigExcel : ExcelResource
{
    public uint ID { get; set; }
    public uint GroupType { get; set; }
    public TimestampConfig? BeginShowTime { get; set; }
    public TimestampConfig? BeginTime { get; set; }
    public uint BeginShowLevel { get; set; }
    public List<uint> SiteList { get; set; } = [];
    public uint UnlockLevel { get; set; }

    public override int GetId()
    {
        return (int)ID;
    }

    public override void Loaded()
    {
        GameData.ChapterGroupConfigData.Add(GetId(), this);
    }
}