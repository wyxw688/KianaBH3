using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("Elf_AstraMate_Data.json")]
public class ElfAstraMateDataExcel : ExcelResource
{
    public int ElfID { get; set; }
    public int MaxLevel { get; set; }
    public int MaxRarity { get; set; }
    public HashName FullName { get; set; } = new();

    [JsonIgnore] public List<ElfSkillDataExcel> SkillList = [];

    public override int GetId()
    {
        return ElfID;
    }

    public override void Loaded()
    {
      GameData.ElfAstraMateData.Add(ElfID, this); 
    }

    public override void AfterAllDone()
    {
        SkillList.AddRange(GameData.ElfSkillData.Values
        .Where(skill => skill.ElfIDList.Contains(ElfID)));
    }
}