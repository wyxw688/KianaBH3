using KianaBH.GameServer.Server.Packet.Send.ExBoss;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.ExBoss;

[Opcode(CmdIds.ExBossStageEndReq)]
public class HandlerExBossStageEndReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = ExBossStageEndReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketExBossStageEndRsp(req.BossId,req.EndStatus));
    }
}
