using KianaBH.Data;
using KianaBH.Proto;
using SqlSugar;

namespace KianaBH.Database.Elfs;

[SugarTable("ElfsData")]
public class ElfsData : BaseDatabaseDataHelper
{
    [SugarColumn(IsJson = true)] public List<ElfData> Elfs { get; set; } = [];
    [SugarColumn(IsJson = true)] public List<ElfFragment> ElfsFragment { get; set; } = [];
}

public class ElfData
{
    public int ElfId { get; set; }
    public int Level { get; set; }
    public int Star { get; set; }
    public int Exp { get; set; }
    public List<int> EquipTalentIdList { get; set; } = [];
    public List<Skill> SkillList { get; set; } = [];
    public int CompensateLevel { get; set; }
    public int TotalCompensateExp { get; set; }
    public long Timestamp { get; set; }

    public Elf ToProto()
    {
        return new Elf
        {
            ElfId = (uint)ElfId,
            Star = (uint)Star,
            Level = (uint)Level,
            Exp = (uint)Exp,
            EquipTalentIdList = { EquipTalentIdList.Select(id => (uint)id) },
            CompensateLevel = (uint)CompensateLevel,
            TotalCompensateExp = (uint)TotalCompensateExp,
            SkillList =
            {
                SkillList.Select(x => new ElfSkill
                {
                    SkillId = (uint)x.SkillId,
                    SkillLevel = (uint)x.SkillLevel,
                })
            }
        };
    }


}

public class ElfFragment
{
    public int ElfId { get; set; }
    public int FragmentNum { get; set; }
}

public class Skill
{
    public int SkillId { get; set; }
    public int SkillLevel { get; set; }
}
