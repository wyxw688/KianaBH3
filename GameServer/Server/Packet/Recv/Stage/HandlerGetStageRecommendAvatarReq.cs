using KianaBH.GameServer.Server.Packet.Send.Stage;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Stage;

[Opcode(CmdIds.GetStageRecommendAvatarReq)]
public class HandlerGetStageRecommendAvatarReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetStageRecommendAvatarReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketGetStageRecommendAvatarRsp(req.IdList,req.Type));
    }
}
