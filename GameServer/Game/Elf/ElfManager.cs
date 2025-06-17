using KianaBH.Data.Excel;
using KianaBH.Data;
using KianaBH.Database;
using KianaBH.Database.Avatar;
using KianaBH.Database.Elfs;
using KianaBH.Enums.Item;
using KianaBH.GameServer.Game.Player;
using KianaBH.GameServer.Server.Packet.Send.Avatar;
using KianaBH.Util.Extensions;
using KianaBH.Proto;
using KianaBH.GameServer.Server.Packet.Send.Elf;

namespace KianaBH.GameServer.Game.Elf;

public class ElfManager(PlayerInstance player) : BasePlayerManager(player)
{
    public ElfsData ElfData = DatabaseHelper.GetInstanceOrCreateNew<ElfsData>(player.Uid);

    public async ValueTask<ElfAstraMateDataExcel?> AddElf(int elfId, int level = 1, int star = 0, bool sync = true)
    {
        if (ElfData.Elfs.Any(a => a.ElfId == elfId)) return null;
        GameData.ElfAstraMateData.TryGetValue(elfId, out var elfExcel);
        if (elfExcel == null) return null;

        var elf = new ElfData
        {
            ElfId = elfId,
            Level = level,
            Timestamp = Extensions.GetUnixSec(),
            Star = elfExcel.MaxRarity <= star ? elfExcel.MaxRarity : star,
        };

        foreach (var skill in elfExcel.SkillList)
        {
            elf.SkillList.Add(new Skill
            {
                SkillId = skill.ElfSkillID,
                SkillLevel = skill.MaxLv,
            });
        };

        ElfData.Elfs.Add(elf);

        if (sync) await Player.SendPacket(new PacketGetElfDataRsp(Player));

        return elfExcel;
    }

}