using KianaBH.GameServer.Server.Packet.Send.Friend;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Friend;

[Opcode(CmdIds.GetFriendListReq)]
public class HandlerGetFriendListReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetFriendListRsp());
    }
}
