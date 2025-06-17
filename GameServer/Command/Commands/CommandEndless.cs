using KianaBH.Data;
using KianaBH.Enums.Player;
using KianaBH.Internationalization;

namespace KianaBH.GameServer.Command.Commands;

[CommandInfo("endless", "Game.Command.Endless.Desc", "Game.Command.Endless.Usage", ["en"], [PermEnum.Admin, PermEnum.Support])]
public class CommandEndless : ICommands
{
    [CommandDefault]
    public async ValueTask SetBoss(CommandArg arg)
    {
        if (!await arg.CheckOnlineTarget()) return;

        var bossIds = new[] { arg.GetInt(0), arg.GetInt(1), arg.GetInt(2) }.ToHashSet();

        var data = GameData.ExBossMonsterData.Values
            .Where(x => bossIds.Contains(x.BossId))
            .Select(x => x.BossId)
            .ToList();

        if (data.Count == 0) 
        {
            await arg.SendMsg(I18NManager.Translate("Game.Command.Endless.NotFound"));
            return;
        }

        arg.Target!.Player!.Data.ExBossMonster.Clear();
        arg.Target!.Player!.Data.ExBossMonster.AddRange(data);

        await arg.SendMsg(I18NManager.Translate("Game.Command.Endless.Success"));
    }
}