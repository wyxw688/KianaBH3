using KianaBH.Data;
using KianaBH.Enums.Player;
using KianaBH.Internationalization;

namespace KianaBH.GameServer.Command.Commands;

[CommandInfo("elf", "Game.Command.Elf.Desc", "Game.Command.Elf.Usage", ["e"], [PermEnum.Admin, PermEnum.Support])]
public class CommandElf : ICommands
{
    [CommandMethod("add")]
    public async ValueTask GetElf(CommandArg arg)
    {
        if (!await arg.CheckOnlineTarget()) return;

        var elfId = arg.GetInt(0);
        if (await arg.GetOption('l') is not int level) return;
        if (await arg.GetOption('s') is not int star) return;

        level = Math.Clamp(level, 1, 80);
        star = Math.Clamp(star, 1, 7);

        if (elfId == -1)
        {
            // add all
            foreach (var config in GameData.ElfAstraMateData.Values)
                await arg.Target!.Player!.ElfManager!.AddElf(config.ElfID, level, config.MaxRarity, sync:false);
            await arg.SendMsg(I18NManager.Translate("Game.Command.Elf.ElfAddedAll"));
            await arg.Target!.Player!.SyncElf();
        }
        else
        {
            var elf = await arg.Target!.Player!.ElfManager!.AddElf(elfId, level, star);
            if (elf == null)
            {
                await arg.SendMsg(I18NManager.Translate("Game.Command.Elf.ElfNotFound"));
                return;
            }
            await arg.SendMsg(I18NManager.Translate("Game.Command.Elf.ElfAdded",elfId.ToString()));
        }
    }
}