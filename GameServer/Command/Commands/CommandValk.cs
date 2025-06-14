using KianaBH.Data;
using KianaBH.Enums.Player;
using KianaBH.Internationalization;

namespace KianaBH.GameServer.Command.Commands;

[CommandInfo("valk", "Game.Command.Valk.Desc", "Game.Command.Valk.Usage", ["v"], [PermEnum.Admin, PermEnum.Support])]
public class CommandValk : ICommands
{
    [CommandMethod("add")]
    public async ValueTask GetRole(CommandArg arg)
    {
        if (!await arg.CheckOnlineTarget()) return;

        var valkId = arg.GetInt(0);
        if (await arg.GetOption('l') is not int level) return;
        if (await arg.GetOption('s') is not int star) return;

        level = Math.Clamp(level, 1, 80);
        star = Math.Clamp(star, 1, 5);

        if (valkId == -1)
        {
            // add all
            foreach (var config in GameData.AvatarData.Values)
                await arg.Target!.Player!.AvatarManager!.AddAvatar(config.AvatarID, level, star,false);
            await arg.SendMsg(I18NManager.Translate("Game.Command.Valk.ValkAddedAll"));
            await arg.Target!.Player!.SyncAll();
        }
        else
        {
            var valk = await arg.Target!.Player!.AvatarManager!.AddAvatar(valkId, level, star);
            if (valk == null)
            {
                await arg.SendMsg(I18NManager.Translate("Game.Command.Valk.ValkNotFound"));
                return;
            }
            await arg.SendMsg(I18NManager.Translate("Game.Command.Valk.ValkAdded",
                valk!.FaceAnimationGroupName ?? valkId.ToString()));
        }
    }
}