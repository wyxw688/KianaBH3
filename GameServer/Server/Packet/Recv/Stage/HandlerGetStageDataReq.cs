using KianaBH.GameServer.Server.Packet.Send.Stage;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Stage;

[Opcode(CmdIds.GetStageDataReq)]
public class HandlerGetStageDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetStageDataReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketGetStageDataRsp(req.StageIdList));
    }
}
