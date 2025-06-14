using KianaBH.GameServer.Server.Packet.Send.Item;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Item;

[Opcode(CmdIds.GetEquipmentForgeDataReq)]
public class HandlerGetEquipmentForgeDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetEquipmentForgeDataRsp());
    }
}
