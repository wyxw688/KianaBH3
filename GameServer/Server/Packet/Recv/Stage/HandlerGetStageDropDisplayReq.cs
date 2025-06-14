using KianaBH.GameServer.Server.Packet.Send.Stage;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Stage;

[Opcode(CmdIds.GetStageDropDisplayReq)]
public class HandlerGetStageDropDisplayReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetStageDropDisplayReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketGetStageDropDisplayRsp(req.StageIdList));
    }
}
