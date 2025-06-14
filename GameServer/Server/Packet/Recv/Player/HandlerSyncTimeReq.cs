using KianaBH.GameServer.Server.Packet.Send.Player;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Player;

[Opcode(CmdIds.SyncTimeReq)]
public class HandlerSyncTimeReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = SyncTimeReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketSyncTimeRsp(req.Seq));
    }
}
