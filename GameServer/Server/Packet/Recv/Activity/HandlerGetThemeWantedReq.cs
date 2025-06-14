using KianaBH.GameServer.Server.Packet.Send.Activity;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Activity;

[Opcode(CmdIds.GetThemeWantedReq)]
public class HandlerGetThemeWantedReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetThemeWantedRsp());
    }
}
