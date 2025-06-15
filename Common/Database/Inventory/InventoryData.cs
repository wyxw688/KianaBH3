using KianaBH.Proto;
using SqlSugar;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KianaBH.Database.Inventory;

[SugarTable("InventoryData")]
public class InventoryData : BaseDatabaseDataHelper
{
    [SugarColumn(IsJson = true)] public List<ItemData> MaterialItems { get; set; } = [];

    [SugarColumn(IsJson = true)] public List<ItemData> WeaponItems { get; set; } = [];

    [SugarColumn(IsJson = true)] public List<ItemData> StigmataItems { get; set; } = [];

    public int NextUniqueId { get; set; } = 100;
}

public class ItemData
{
    public int UniqueId { get; set; }
    public int ItemId { get; set; }
    public int SubItemId { get; set; }
    public int Count { get; set; }
    public int Level { get; set; }
    public int Exp { get; set; }
    public bool IsLocked { get; set; }
    public bool IsAffixIdentify { get; set; }
    public uint CancelLockedTime { get; set; }
    public bool Extracted { get; set; }
    public int SlotNum { get; set; }
    public int RefineValue { get; set; }
    public int PromoteTimes { get; set; }
    public int Homology { get; set; }
    public List<int> QuantumBranchLists { get; set; } = [];
    public List<Rune> RuneLists { get; set; } = [];
    public List<Rune> WaitSelectRuneLists { get; set; } = [];
    public List<RuneGroup> WaitSelectRuneGroupLists { get; set; } = [];
    public int EquipAvatar { get; set; }


    public Material ToMaterialProto()
    {
        return new Material
        {
            Id = (uint)ItemId,
            Num = (uint)Count
        };
    }

    public Weapon ToWeaponProto()
    {
        return new Weapon
        {
            Id = (uint)ItemId,
            UniqueId = (uint)UniqueId,
            Level = (uint)Level,
            Exp = (uint)Exp,
            IsProtected = IsLocked,
            IsExtracted = Extracted,
        };
    }

    public Stigmata ToStigmataProto()
    {
        return new Stigmata
        {
            Id= (uint)ItemId,
            UniqueId= (uint)UniqueId,
            Level= (uint)Level,
            Exp= (uint)Exp,
            SlotNum = (uint)SlotNum,
            RefineValue = (uint)RefineValue,
            PromoteTimes = (uint)PromoteTimes,
            IsProtected= IsLocked,
            IsAffixIdentify = IsAffixIdentify,
            RuneList =
            {
                RuneLists.Select(x => new StigmataRune
                {
                    RuneId = (uint)x.RuneId,
                    StrengthPercent = (uint)x.Strength,
                })
            },
            WaitSelectRuneList =
            {
                WaitSelectRuneLists.Select(x => new StigmataRune
                {
                    RuneId = (uint)x.RuneId,
                    StrengthPercent = (uint)x.Strength,
                })
            },
            WaitSelectRuneGroupList =
            {
                WaitSelectRuneGroupLists.Select(x => new StigmataRuneGroup
                {
                    UniqueId = (uint)x.UniqueId,
                    RuneList =
                    {
                        RuneLists.Select(l => new StigmataRune
                        {
                            RuneId = (uint)l.RuneId,
                            StrengthPercent = (uint)l.Strength,
                        })
                    }
                })
            }
        };
    }
}

public class RuneGroup
{
    public int UniqueId { get; set; }
    public List<Rune> RuneLists { get; set; } = [];
}

public class Rune
{
    public int RuneId { get; set; }
    public int Strength { get; set; }
}
