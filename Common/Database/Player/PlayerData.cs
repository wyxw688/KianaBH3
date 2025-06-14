using System.Drawing;
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
    public uint Level { get; set; } = 88;
    public uint Exp { get; set; } = 0;
    public uint HCoin { get; set; } = 0;
    public uint Stamina { get; set; } = 240;
    public uint HeadIcon { get; set; } = 161090;
    public uint HeadFrame { get; set; } = 200001;
    public uint WarshipId { get; set; } = 400004;
    public uint PhonePendantId { get; set; } = 350005;
    public uint AssistantAvatarId { get; set; } = 101;
    public uint BirthDay { get; set; } = 0;
    [SugarColumn(IsJson = true)] public WarshipAvatarData WarshipAvatar { get; set; } = new();
    [SugarColumn(IsNullable = true)] public long LastActiveTime { get; set; }
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
            AssistantAvatarId = 0,
            Birthday = BirthDay,
            Nickname = Name,
            Level = Level,
            Exp = Exp,
            Hcoin = HCoin,
            CustomHeadId = HeadIcon,
            RegisterTime = (uint)RegisterTime,
            WarshipAvatar = new Proto.WarshipAvatarData
            {
                WarshipFirstAvatarId = 0,
                WarshipSecondAvatarId = 0,
            },
            SelfDesc = Signature,
            UseFrameId = HeadFrame,
            OnPhonePendantId = PhonePendantId,
            Stamina = Stamina,
            StaminaRecoverConfigTime = GameConstants.STAMINA_RECOVERY_TIME,
            StaminaRecoverLeftTime = GameConstants.STAMINA_RECOVERY_TIME,
            EquipmentSizeLimit = GameConstants.INVENTORY_MAX_EQUIPMENT,
            TypeList = { Enumerable.Range(2, 38).Select(i => (uint)i) },
            LevelLockId = 1,
            WarshipTheme = new WarshipThemeData
            {
                WarshipId=0
            },
            TotalLoginDays = 1
        };
    }
}

public class WarshipAvatarData
{
    public uint FirstAvatarId { get; set; } = 101;
    public uint SecondAvatarId { get; set; } = 0;
}