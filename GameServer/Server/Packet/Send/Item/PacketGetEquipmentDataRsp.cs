using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Item;

public class PacketGetEquipmentDataRsp : BasePacket
{
    public PacketGetEquipmentDataRsp(PlayerInstance player) : base(CmdIds.GetEquipmentDataRsp)
    {
        var proto = new GetEquipmentDataRsp
        {
            WeaponList = { player.InventoryManager!.Data.WeaponItems.Select(weapon => weapon.ToWeaponProto()) }
        };

        SetData(proto);
    }
}
