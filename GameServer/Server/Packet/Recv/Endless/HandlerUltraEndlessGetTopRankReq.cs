using KianaBH.GameServer.Server.Packet.Send.Endless;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Endless;

[Opcode(CmdIds.UltraEndlessGetTopRankReq)]
public class HandlerUltraEndlessGetTopRankReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = UltraEndlessGetTopRankReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketUltraEndlessGetTopRankRsp(connection.Player!,req.ScheduleId));
    }
}
