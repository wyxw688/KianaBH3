using KianaBH.GameServer.Server.Packet.Send.Dummy;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Dummy;

[Opcode(CmdIds.GetShopListReq)]
public class HandlerGetShopListReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetShopListRsp());
    }
}
