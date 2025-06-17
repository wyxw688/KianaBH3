using KianaBH.Data;
using KianaBH.Proto;
using KianaBH.Util;
using KianaBH.Util.Extensions;
using SqlSugar;

namespace KianaBH.Database.Player;

[SugarTable("Player")]
public class PlayerData : BaseDatabaseDataHelper
{
    public string? Name { get; set; } = "";
    public string? Signature { get; set; } = "KianaPS";
    public int Level { get; set; } = 88;
    public int Exp { get; set; } = 0;
    public int HCoin { get; set; } = 0;
    public int Stamina { get; set; } = 240;
    public int HeadIcon { get; set; } = 161001;
    public int HeadFrame { get; set; } = 200001;
    public int WarshipId { get; set; } = 0;
    public int PhonePendantId { get; set; } = 350005;
    public int AssistantAvatarId { get; set; } = 101;
    public int BirthDay { get; set; } = 0;
    [SugarColumn(IsJson = true)] public WarshipAvatarData WarshipAvatar { get; set; } = new();
    [SugarColumn(IsNullable = true)] public long LastActiveTime { get; set; }
    [SugarColumn(IsJson = true)] public UltraEndless Abyss { get; set; } = new();
    public List<int> ExBossMonster { get; set; } = new List<int> { 51016, 4021, 36112 };
    public long RegisterTime { get; set; } = Extensions.GetUnixSec();

    public static PlayerData? GetPlayerByUid(long uid)
    {
        var result = DatabaseHelper.GetInstance<PlayerData>((int)uid);
        return result;
    }
    public GetMainDataRsp ToProto()
    {
        return new GetMainDataRsp
        {
            IsAll = true,
            AssistantAvatarId = (uint)AssistantAvatarId,
            Birthday = (uint)BirthDay,
            Nickname = Name,
            Level = (uint)Level,
            Exp = (uint)Exp,
            Hcoin = (uint)HCoin,
            CustomHeadId = (uint)HeadIcon,
            RegisterTime = (uint)RegisterTime,
            WarshipAvatar = new Proto.WarshipAvatarData
            {
                WarshipFirstAvatarId = (uint)WarshipAvatar.FirstAvatarId,
                WarshipSecondAvatarId = (uint)WarshipAvatar.SecondAvatarId,
            },
            SelfDesc = Signature,
            UseFrameId = (uint)HeadFrame,
            OnPhonePendantId = (uint)PhonePendantId,
            Stamina = (uint)Stamina,
            StaminaRecoverConfigTime = GameConstants.STAMINA_RECOVERY_TIME,
            StaminaRecoverLeftTime = GameConstants.STAMINA_RECOVERY_TIME,
            EquipmentSizeLimit = GameConstants.INVENTORY_MAX_EQUIPMENT,
            TypeList = { Enumerable.Range(2, 38).Select(i => (uint)i) },
            LevelLockId = 1,
            WarshipTheme = new WarshipThemeData
            {
                WarshipId=(uint)WarshipId
            },
            TotalLoginDays = 1
        };
    }

    public uint GetCupNum()
    {
        uint GroupLevel = (uint)Abyss.GroupLevel;
        if (GroupLevel > 6) return (GroupLevel - 6) * 367 + 900;
        else if (GroupLevel > 1) return (GroupLevel - 2) * 200 + 100;
        else return 0;
    }

    public List<UltraEndlessSite> ToUltraEndlessSiteProto()
    {
        int currentSiteId = Abyss.SiteId;

        var currentSiteData = GameData.UltraEndlessSiteData.Values
            .FirstOrDefault(x => x.SiteID == currentSiteId);

        if (currentSiteData == null) return [];

        if (currentSiteData.SiteNodeName.StartsWith("Area") &&
            int.TryParse(currentSiteData.SiteNodeName.Substring(4), out int areaNumber) &&
            areaNumber > 1) currentSiteId -= (areaNumber - 1);

        var siteIds = Enumerable.Range(0, 4).Select(i => currentSiteId + i).ToHashSet();

        var siteDatas = GameData.UltraEndlessSiteData.Values
            .Where(site => siteIds.Contains(site.SiteID));

        return siteDatas.Select(site => new UltraEndlessSite
        {
            SiteId = (uint)site.SiteID,
            FloorList =
            {
                GameData.UltraEndlessFloorData.Values
                    .SelectMany(floorList => floorList)
                    .Where(floor => floor.StageID == site.StageID)
                    .Select(floor => new UltraEndlessFloor
                    {
                        Floor = (uint)floor.FloorID,
                        MaxScore = site.SiteNodeName == "Area3" ? 0 : (uint)floor.MaxScore
                    })
            }
        }).ToList();
    }
}

public class WarshipAvatarData
{
    public int FirstAvatarId { get; set; } = 101;
    public int SecondAvatarId { get; set; } = 0;
}

public class UltraEndless
{
    public int SiteId { get; set; } = 6691;
    public int GroupLevel { get; set; } = 8;
    public int DynamicHard { get; set; } = 100;

}