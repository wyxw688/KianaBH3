using KianaBH.GameServer.Server.Packet.Send.Endless;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Endless;

[Opcode(CmdIds.GetEndlessStatusReq)]
public class HandlerGetEndlessStatusReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetEndlessStatusRsp());
    }
}
