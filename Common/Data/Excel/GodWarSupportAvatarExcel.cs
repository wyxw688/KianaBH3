namespace KianaBH.Data.Excel;

[ResourceEntity("GodWarSupportAvatar.json")]
public class GodWarSupportAvatarExcel : ExcelResource
{
    public int SupportAvatarID { get; set; }
    
    public override int GetId()
    {
        return SupportAvatarID;
    }

    public override void Loaded()
    {
        GameData.GodWarSupportAvatarData.Add(SupportAvatarID, this);
    }
}