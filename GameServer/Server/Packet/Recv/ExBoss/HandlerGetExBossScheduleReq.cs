using KianaBH.GameServer.Server.Packet.Send.ExBoss;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.ExBoss;

[Opcode(CmdIds.GetExBossScheduleReq)]
public class HandlerGetExBossScheduleReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetExBossScheduleRsp());
    }
}
