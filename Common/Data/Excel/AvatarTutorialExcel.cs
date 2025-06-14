namespace KianaBH.Data.Excel;

[ResourceEntity("AvatarTutorial.json")]
public class AvatarTutorialExcel : ExcelResource
{
    public uint ActivityID { get; set; }

    public override int GetId()
    {
        return (int)ActivityID;
    }

    public override void Loaded()
    {
      GameData.AvatarTutorialData.Add(GetId(), this); 
    }
}