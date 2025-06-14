namespace KianaBH.Data.Excel;

[ResourceEntity("GodWarRelationData.json")]
public class GodWarRelationDataExcel : ExcelResource
{
    public int AvatarID { get; set; }
    public int RoleID { get; set; }
    public int Level { get; set; }
    public int MaxLevel { get; set; }
    
    public override int GetId()
    {
        return AvatarID;
    }

    public override void Loaded()
    {
        GameData.GodWarRelationData.Add(this);
    }
}