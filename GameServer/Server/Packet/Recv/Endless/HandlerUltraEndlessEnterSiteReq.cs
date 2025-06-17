using KianaBH.GameServer.Server.Packet.Send.Endless;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Endless;

[Opcode(CmdIds.UltraEndlessEnterSiteReq)]
public class HandlerUltraEndlessEnterSiteReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = UltraEndlessEnterSiteReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketUltraEndlessEnterSiteRsp(req.SiteId));
    }
}
