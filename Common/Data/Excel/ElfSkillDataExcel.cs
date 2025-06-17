namespace KianaBH.Data.Excel;

[ResourceEntity("ElfSkillData.json")]
public class ElfSkillDataExcel : ExcelResource
{
    public int ElfSkillID { get; set; }
    public int MaxLv { get; set; }
    public List<int> ElfIDList { get; set; } = [];
    public override int GetId()
    {
        return ElfSkillID;
    }

    public override void Loaded()
    {
      GameData.ElfSkillData.Add(GetId(), this); 
    }
}