using KianaBH.Data;
using KianaBH.Enums.Item;
using KianaBH.Enums.Player;
using KianaBH.Internationalization;

namespace KianaBH.GameServer.Command.Commands;

[CommandInfo("giveall", "Game.Command.GiveAll.Desc", "Game.Command.GiveAll.Usage", ["ga"], [PermEnum.Admin, PermEnum.Support])]
public class CommandGiveall : ICommands
{
    [CommandMethod("weapon")]
    public async ValueTask GiveWeapon(CommandArg arg)
    {
        if (!await arg.CheckOnlineTarget()) return;
        foreach (var conf in GameData.WeaponData.Values.Where(weapon => weapon.Rarity == weapon.MaxRarity))
        {
            var item = await arg.Target!.Player!.InventoryManager!.AddItem(conf.ID, 1, ItemMainTypeEnum.Weapon, conf.MaxLv, sync:false);
        }
        await arg.Target!.Player!.SyncWeapon();
        await arg.SendMsg(I18NManager.Translate("Game.Command.GiveAll.GiveAllItems", I18NManager.Translate("Word.Weapon")));
    }
}
