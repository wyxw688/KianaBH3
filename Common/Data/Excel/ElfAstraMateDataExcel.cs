using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("Elf_AstraMate_Data.json")]
public class ElfAstraMateDataExcel : ExcelResource
{
    public uint ElfID { get; set; }
    public uint MaxLevel { get; set; }
    public uint MaxRarity { get; set; }

    [JsonIgnore] public List<ElfSkillDataExcel> SkillList = [];

    public override int GetId()
    {
        return (int)ElfID;
    }

    public override void Loaded()
    {
      GameData.ElfAstraMateData.Add(GetId(), this); 
    }

    public override void AfterAllDone()
    {
        GameData.ElfSkillData.TryGetValue(GetId(), out var Skills);
        if (Skills == null || !Skills.ElfIds.Contains(ElfID)) return;
        SkillList.Add(Skills);
    }
}