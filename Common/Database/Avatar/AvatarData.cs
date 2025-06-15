using SqlSugar;
using KianaBH.Proto;

namespace KianaBH.Database.Avatar;

[SugarTable("Avatar")]
public class AvatarData : BaseDatabaseDataHelper
{
    [SugarColumn(IsJson = true)] public List<AvatarInfo> Avatars { get; set; } = [];
}

public class AvatarInfo
{
    public int AvatarId { get; set; }
    public int Star { get; set; }
    public int Level { get; set; }
    public int Exp { get; set; }
    public int Fragment { get; set; }
    public int WeaponUniqueId { get; set; }
    public Dictionary<int, int> Stigmata { get; set; } = [];
    public List<AvatarSkill> SkillList { get; set; } = [];
    public int TouchGoodFeel { get; set; }
    public int TodayHasAddGoodFeel { get; set; }
    public int StageGoodFeel { get; set; }
    public List<int> DressList { get; set; } = [];
    public int DressId { get; set; }
    public AvatarBindEquipMode Mode { get; set; } = AvatarBindEquipMode.AvatarBindEquipCommon;
    public AvatarArtifactDetail? AvatarArtifact { get; set; }
    public int SubStar { get; set; }
    public long Timestamp { get; set; }
    public Proto.Avatar ToProto()
    {
        var proto = new Proto.Avatar
        {
            AvatarId = (uint)AvatarId,
            Star = (uint)Star,
            Level = (uint)Level,
            Exp = (uint)Exp,
            Fragment = (uint)Fragment,
            WeaponUniqueId = (uint)WeaponUniqueId,
            StigmataUniqueId1 = (uint)(Stigmata.TryGetValue(1, out var id1) ? id1 : 0),
            StigmataUniqueId2 = (uint)(Stigmata.TryGetValue(2, out var id2) ? id2 : 0),
            StigmataUniqueId3 = (uint)(Stigmata.TryGetValue(3, out var id3) ? id3 : 0),
            TouchGoodfeel = (uint)TouchGoodFeel,
            TodayHasAddGoodfeel = (uint)TodayHasAddGoodFeel,
            StageGoodfeel = (uint)StageGoodFeel,
            DressId = (uint)DressId,
            Mode = Mode,
            SubStar = (uint)SubStar,
        };

        foreach (var dressId in DressList)
        {
            proto.DressList.Add((uint)dressId);
        }

        foreach (var skill in SkillList)
        {
            var avatarSkill = new Proto.AvatarSkill
            {
                SkillId = (uint)skill.SkillId
            };

            avatarSkill.SubSkillList.AddRange(skill.SubSkillList.Select(x => new Proto.AvatarSubSkill
            {
                SubSkillId = (uint)x.SubSkillId,
                Level = (uint)x.Level,
                IsMask = x.IsMask
            }));

            proto.SkillList.Add(avatarSkill);
        }
        return proto;
    }

}
public class AvatarSkill
{
    public int SkillId { get; set; }
    public List<AvatarSubSkill> SubSkillList { get; set; } = [];
}
public class AvatarSubSkill
{
    public int SubSkillId { get; set; }
    public int Level { get; set; }
    public bool IsMask { get; set; }
}
public class AvatarArtifactDetail
{
    public int ArtifactId { get; set; }
    public int ArtifactLevel { get; set; }
    public bool IsArtifactSwitchOn { get; set; }
}