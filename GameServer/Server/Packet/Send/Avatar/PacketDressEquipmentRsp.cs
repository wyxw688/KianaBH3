using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Avatar;

public class PacketDressEquipmentRsp : BasePacket
{
    public PacketDressEquipmentRsp(EquipmentSlot slot, uint uniqueId) : base(CmdIds.DressEquipmentRsp)
    {
        var proto = new DressEquipmentRsp
        {
            UniqueId = uniqueId,
            Slot = slot
        };

        SetData(proto);
    }
}
