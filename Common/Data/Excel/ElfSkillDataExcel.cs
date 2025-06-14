namespace KianaBH.Data.Excel;

[ResourceEntity("ElfSkillData.json")]
public class ElfSkillDataExcel : ExcelResource
{
    public uint ElfSkillID { get; set; }
    public uint MaxLv { get; set; }
    public List<uint> ElfIds { get; set; } = [];
    public override int GetId()
    {
        return (int)ElfSkillID;
    }

    public override void Loaded()
    {
      GameData.ElfSkillData.Add(GetId(), this); 
    }
}