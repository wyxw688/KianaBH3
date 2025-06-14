namespace KianaBH.Data.Excel;

[ResourceEntity("ActivityTower.json")]
public class ActivityTowerExcel : ExcelResource
{
    public uint ActivityID { get; set; }

    public override int GetId()
    {
        return (int)ActivityID;
    }

    public override void Loaded()
    {
        GameData.ActivityTowerData.Add(GetId(), this);
    }
}