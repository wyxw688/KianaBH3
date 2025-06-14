using KianaBH.GameServer.Server.Packet.Send.Client;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Client;

[Opcode(CmdIds.ReportClientDataVersionReq)]
public class HandlerReportClientDataVersionReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = ReportClientDataVersionReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketReportClientDataVersionRsp(req.Version));
    }
}
