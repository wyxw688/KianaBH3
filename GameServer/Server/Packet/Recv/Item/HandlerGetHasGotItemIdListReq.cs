using KianaBH.GameServer.Server.Packet.Send.Item;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Item;

[Opcode(CmdIds.GetHasGotItemIdListReq)]
public class HandlerGetHasGotItemIdListReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetHasGotItemIdListRsp());
    }
}
