using KianaBH.Data;
using KianaBH.Data.Excel;
using KianaBH.Database;
using KianaBH.Database.Avatar;
using KianaBH.Enums.Item;
using KianaBH.GameServer.Game.Player;
using KianaBH.GameServer.Server.Packet.Send.Avatar;
using KianaBH.Util.Extensions;


namespace KianaBH.GameServer.Game.Avatar;

public class AvatarManager(PlayerInstance player) : BasePlayerManager(player)
{
    public AvatarData AvatarData { get; } = DatabaseHelper.GetInstanceOrCreateNew<AvatarData>(player.Uid);
    public async ValueTask<AvatarDataExcel?> AddAvatar(int avatarId, int level = 1, int? star = null, bool sync = true)
    {
        if (AvatarData.Avatars.Any(a => a.AvatarId == avatarId)) return null;
        GameData.AvatarData.TryGetValue(avatarId, out var avatarExcel);
        if (avatarExcel == null) return null;

        var avatar = new AvatarInfo
        {
            Level = level,
            Timestamp = Extensions.GetUnixSec(),
            Star = star ?? avatarExcel.UnlockStar,
            DressId = avatarExcel.DefaultDressId,
            DressList = {avatarExcel.DefaultDressId},
            AvatarId = avatarExcel.AvatarID,
        };

        foreach (var skill in avatarExcel.SkillList)
        {
            avatar.SkillList.Add(new AvatarSkill
            {
                SkillId = skill
            });
        };

        var weapon = GameData.WeaponData.TryGetValue(avatarExcel.InitialWeapon, out var weaponConfig);
        if (weaponConfig != null) 
        {
            var item = await Player.InventoryManager!.AddItem(avatarExcel.InitialWeapon, 1, ItemMainTypeEnum.Weapon, weaponConfig.MaxLv, avatarId, sync: sync);
            if (item != null)
            {
                avatar.WeaponUniqueId = item!.UniqueId;
            };
        };

        AvatarData.Avatars.Add(avatar);

        if (sync) await Player.SendPacket(new PacketGetAvatarDataRsp(new List<AvatarInfo> { avatar }, false));

        return avatarExcel;
    }

    public AvatarInfo? GetAvatar(uint avatarId)
    {

        return AvatarData.Avatars.Find(avatar => avatar.AvatarId == avatarId);
    }
}