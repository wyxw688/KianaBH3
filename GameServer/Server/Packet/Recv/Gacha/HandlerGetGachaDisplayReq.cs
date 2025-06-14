using KianaBH.GameServer.Server.Packet.Send.Gacha;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Gacha;

[Opcode(CmdIds.GetGachaDisplayReq)]
public class HandlerGetGachaDisplayReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetGachaDisplayRsp());
    }
}
