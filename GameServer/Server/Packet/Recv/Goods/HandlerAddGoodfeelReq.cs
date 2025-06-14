using KianaBH.GameServer.Server.Packet.Send.Goods;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Goods;

[Opcode(CmdIds.AddGoodfeelReq)]
public class HandlerAddGoodfeelReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketAddGoodfeelRsp());
    }
}
