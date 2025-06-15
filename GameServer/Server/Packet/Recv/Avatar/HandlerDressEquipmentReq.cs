using KianaBH.GameServer.Server.Packet.Send.Avatar;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Avatar;

[Opcode(CmdIds.DressEquipmentReq)]
public class HandlerDressEquipmentReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = DressEquipmentReq.Parser.ParseFrom(data);
        var player = connection.Player!;

        switch (req.Slot)
        {
            case EquipmentSlot.Weapon1:
                await player.InventoryManager!.EquipAvatar((int)req.AvatarId, (int)req.UniqueId);
                break;
            case EquipmentSlot.Stigmata1:
            case EquipmentSlot.Stigmata2:
            case EquipmentSlot.Stigmata3:
                await player.InventoryManager!.EquipStigmata((int)req.AvatarId, (int)req.UniqueId, ((int)req.Slot - 1));
                break;
        }
        await connection.SendPacket(new PacketDressEquipmentRsp(req.Slot,req.UniqueId));
    }
}
