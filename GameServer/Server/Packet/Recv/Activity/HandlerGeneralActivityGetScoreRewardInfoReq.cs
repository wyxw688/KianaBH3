using KianaBH.GameServer.Server.Packet.Send.Activity;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Activity;

[Opcode(CmdIds.GeneralActivityGetScoreRewardInfoReq)]
public class HandlerGeneralActivityGetScoreRewardInfoReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GeneralActivityGetScoreRewardInfoReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketGeneralActivityGetScoreRewardInfoRsp(req.ActivityIdList));
    }
}
