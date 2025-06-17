using KianaBH.GameServer.Server.Packet.Send.Endless;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Endless;

[Opcode(CmdIds.UltraEndlessReportSiteFloorReq)]
public class HandlerUltraEndlessReportSiteFloorReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = UltraEndlessReportSiteFloorReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketUltraEndlessReportSiteFloorRsp(req.SiteId,req.Floor));
    }
}
