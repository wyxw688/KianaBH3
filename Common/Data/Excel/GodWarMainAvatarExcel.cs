namespace KianaBH.Data.Excel;

[ResourceEntity("GodWarMainAvatar.json")]
public class GodWarMainAvatarExcel : ExcelResource
{
    public int MainAvatarID { get; set; }

    public override int GetId()
    {
        return MainAvatarID;
    }

    public override void Loaded()
    {
        GameData.GodWarMainAvatarData.Add(MainAvatarID, this);
    }
}