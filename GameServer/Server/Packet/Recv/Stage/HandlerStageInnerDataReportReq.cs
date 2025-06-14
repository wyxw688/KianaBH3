using KianaBH.GameServer.Server.Packet.Send.Stage;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Stage;

[Opcode(CmdIds.StageInnerDataReportReq)]
public class HandlerStageInnerDataReportReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketStageInnerDataReportRsp());
    }
}
