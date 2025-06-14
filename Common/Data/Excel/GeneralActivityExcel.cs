namespace KianaBH.Data.Excel;

[ResourceEntity("GeneralActivity.json")]
public class GeneralActivityExcel : ExcelResource
{
     public uint AcitivityID { get; set; }
     public uint Series { get; set; }

    public override int GetId()
    {
        return (int)AcitivityID;
    }

    public override void Loaded()
    {
        GameData.GeneralActivityData.Add(GetId(), this);
    }
}