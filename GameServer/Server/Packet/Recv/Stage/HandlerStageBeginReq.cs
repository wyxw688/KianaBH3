using KianaBH.GameServer.Server.Packet.Send.Stage;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Stage;

[Opcode(CmdIds.StageBeginReq)]
public class HandlerStageBeginReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = StageBeginReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketStageBeginRsp(req.StageId));
    }
}
