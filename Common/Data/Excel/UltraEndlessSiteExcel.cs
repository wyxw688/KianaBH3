
namespace KianaBH.Data.Excel;

[ResourceEntity("UltraEndlessSite.json")]
public class UltraEndlessSiteExcel : ExcelResource
{
    public int StageID { get; set; }
    public int BuffID { get; set; }
    public string SiteNodeName { get; set; } = "";
    public string SiteName { get; set; } = "";
    public int HardLevelGroup { get; set; }
    public int SiteID { get; set; }

    public override int GetId()
    {
        return SiteID;
    }

    public override void Loaded()
    {
        GameData.UltraEndlessSiteData.Add(SiteID, this);
    }
}
