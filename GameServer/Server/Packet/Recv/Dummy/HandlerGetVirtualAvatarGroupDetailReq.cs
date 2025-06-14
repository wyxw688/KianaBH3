using KianaBH.GameServer.Server.Packet.Send.Dummy;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Dummy;

[Opcode(CmdIds.GetVirtualAvatarGroupDetailReq)]
public class HandlerGetVirtualAvatarGroupDetailReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetVirtualAvatarGroupDetailReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketGetVirtualAvatarGroupDetailRsp(req.GroupId));
    }
}
