using KianaBH.GameServer.Server.Packet.Send.Auth;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Auth;

[Opcode(CmdIds.GetAuthkeyReq)]
public class HandlerGetAuthkeyReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetAuthkeyReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketGetAuthkeyRsp(req.AuthAppid));
    }
}
