using KianaBH.Data;
using KianaBH.Database;
using KianaBH.Database.Inventory;
using KianaBH.Enums.Item;
using KianaBH.GameServer.Game.Player;
using KianaBH.GameServer.Server.Packet.Send.Item;
using KianaBH.Proto;
using KianaBH.Util;
using static KianaBH.Proto.MasterPupilRetcode.Types;

namespace KianaBH.GameServer.Game.Inventory;

public class InventoryManager(PlayerInstance player) : BasePlayerManager(player)
{
    public InventoryData Data = DatabaseHelper.GetInstanceOrCreateNew<InventoryData>(player.Uid);

    public async ValueTask<ItemData?> AddItem(int itemId, int count, ItemMainTypeEnum type, int level = 1, int equipAvatar = 0, bool sync = true)
    {
        ItemData? itemData = null;

        switch (type)
        {
            case ItemMainTypeEnum.Material:
                GameData.MaterialData.TryGetValue(itemId, out var materialConfig);
                if (materialConfig == null) return null;
                itemData = await PutItem(itemId, count, type);
                break;
            case ItemMainTypeEnum.Weapon:
                GameData.WeaponData.TryGetValue(itemId, out var weaponConfig);
                if (weaponConfig == null) return null;
                itemData = await PutItem(itemId, 1, type, level, equipAvatar: equipAvatar, uniqueId: ++Data.NextUniqueId);
                break;
            default:
                break;
        }

        if (sync) await Player.SendPacket(new PacketGetEquipmentDataRsp(Player));

        return itemData;
    }

    public async ValueTask<ItemData> PutItem(int itemId, int count, ItemMainTypeEnum type, int level = 0,
        int exp = 0, int equipAvatar = 0, int uniqueId = 0)
    {
        var item = new ItemData
        {
            ItemId = itemId,
            Count = count,
            Level = level,
            Exp = exp,
            EquipAvatar = equipAvatar,
        };

        if (uniqueId > 0) item.UniqueId = uniqueId;

        switch (type)
        {
            case ItemMainTypeEnum.Material:
                var oldItem = Data.MaterialItems.Find(x => x.ItemId == itemId);
                if (oldItem != null)
                {
                    oldItem.Count += count;
                    item = oldItem;
                    break;
                }

                Data.MaterialItems.Add(item);
                break;
            case ItemMainTypeEnum.Weapon:
                if (Data.WeaponItems.Count + 1 > GameConstants.INVENTORY_MAX_EQUIPMENT)
                {
                    return item;
                }

                Data.WeaponItems.Add(item);
                break;
            case ItemMainTypeEnum.Stigmata:
                if (Data.StigmataItems.Count + 1 > GameConstants.INVENTORY_MAX_EQUIPMENT)
                {
                    return item;
                }
                Data.StigmataItems.Add(item);
                break;
        }

        return item;
    }
}