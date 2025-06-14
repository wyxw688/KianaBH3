using KianaBH.GameServer.Server.Packet.Send.Friend;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Friend;

[Opcode(CmdIds.GetFriendRemarkListReq)]
public class HandlerGetFriendRemarkListReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetFriendRemarkListRsp());
    }
}
