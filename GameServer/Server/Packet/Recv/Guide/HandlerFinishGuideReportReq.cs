using KianaBH.GameServer.Server.Packet.Send.Guide;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Guide;

[Opcode(CmdIds.FinishGuideReportReq)]
public class HandlerFinishGuideReportReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = FinishGuideReportReq.Parser.ParseFrom(data);
        foreach (var groupId in req.GuideIdList)
        {
            if (!connection.Player!.GuideData!.GuideFinishList.Contains(groupId))
                connection.Player.GuideData.GuideFinishList.Add(groupId);
        }
       
        await connection.SendPacket(new PacketFinishGuideReportRsp(connection.Player!));
    }
}
