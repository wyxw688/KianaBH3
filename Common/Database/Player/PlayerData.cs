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
}

public class WarshipAvatarData
{
    public int FirstAvatarId { get; set; } = 101;
    public int SecondAvatarId { get; set; } = 0;
}