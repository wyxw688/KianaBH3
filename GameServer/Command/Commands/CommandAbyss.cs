using Google.Protobuf.WellKnownTypes;
using System.Numerics;
using KianaBH.Data;
using KianaBH.Enums.Player;
using KianaBH.Internationalization;

namespace KianaBH.GameServer.Command.Commands;

[CommandInfo("abyss", "Game.Command.Abyss.Desc", "Game.Command.Abyss.Usage", ["ab"], [PermEnum.Admin, PermEnum.Support])]
public class CommandAbyss : ICommands
{
    [CommandMethod("bracket")]
    public async ValueTask SetBracket(CommandArg arg)
    {
        if (!await arg.CheckOnlineTarget()) return;
        var bracket = arg.GetInt(0); 
        arg.Target!.Player!.Data.Abyss.GroupLevel = bracket > 0 && bracket < 10 ? bracket : 9;
        await arg.SendMsg(I18NManager.Translate("Game.Command.Abyss.Success", I18NManager.Translate("Word.Bracket")));
    }

    [CommandMethod("temp")]
    public async ValueTask SetDisturbance(CommandArg arg)
    {
        if (!await arg.CheckOnlineTarget()) return;
        var disturbanceValue = arg.GetInt(0);
        arg.Target!.Player!.Data.Abyss.DynamicHard = disturbanceValue;
        await arg.SendMsg(I18NManager.Translate("Game.Command.Abyss.Success", I18NManager.Translate("Word.Disturbance")));
    }

    [CommandMethod("site")]
    public async ValueTask SetSite(CommandArg arg)
    {
        if (!await arg.CheckOnlineTarget()) return;
        var siteId = arg.GetInt(0);

        var data = GameData.UltraEndlessSiteData.Values
            .FirstOrDefault(x => x.SiteID == siteId);
        if (data == null)
        {
            await arg.SendMsg(I18NManager.Translate("Game.Command.Abyss.AreaNotFound"));
            return;
        }

        arg.Target!.Player!.Data.Abyss.SiteId = siteId;
        await arg.SendMsg(I18NManager.Translate("Game.Command.Abyss.Success", I18NManager.Translate("Word.Site")));
    }
}