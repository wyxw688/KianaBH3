using KianaBH.GameServer.Server.Packet.Send.ExBoss;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.ExBoss;

[Opcode(CmdIds.GetExBossRankReq)]
public class HandlerGetExBossRankReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetExBossRankReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketGetExBossRankRsp(connection.Player!,req.BossId,req.RankId));
    }
}
