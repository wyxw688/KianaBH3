using KianaBH.GameServer.Server.Packet.Send.Collection;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Collection;

[Opcode(CmdIds.GetCollectionListReq)]
public class HandlerGetCollectionListReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetCollectionListRsp());
    }
}
