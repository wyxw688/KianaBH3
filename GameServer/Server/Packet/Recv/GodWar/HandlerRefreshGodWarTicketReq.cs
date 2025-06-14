using KianaBH.GameServer.Server.Packet.Send.GodWar;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.GodWar;

[Opcode(CmdIds.RefreshGodWarTicketReq)]
public class HandlerRefreshGodWarTicketReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = RefreshGodWarTicketReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketRefreshGodWarTicketRsp(req.GodWarId));
    }
}
