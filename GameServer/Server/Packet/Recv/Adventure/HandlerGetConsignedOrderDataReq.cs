using KianaBH.GameServer.Server.Packet.Send.Adventure;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Adventure;

[Opcode(CmdIds.GetConsignedOrderDataReq)]
public class HandlerGetConsignedOrderDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetConsignedOrderDataRsp());
    }
}
