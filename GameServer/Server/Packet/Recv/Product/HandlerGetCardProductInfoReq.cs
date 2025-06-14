using KianaBH.GameServer.Server.Packet.Send.Product;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Product;

[Opcode(CmdIds.GetCardProductInfoReq)]
public class HandlerGetCardProductInfoReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetCardProductInfoRsp());
    }
}
