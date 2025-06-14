using KianaBH.GameServer.Server.Packet.Send.OpenWorld;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.OpenWorld;

[Opcode(CmdIds.GetNewOpenworldReq)]
public class HandlerGetNewOpenworldReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetNewOpenworldRsp());
    }
}
