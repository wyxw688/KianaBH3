using Google.Protobuf.Collections;
using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Guide;

public class PacketFinishGuideReportRsp : BasePacket
{
    public PacketFinishGuideReportRsp(PlayerInstance player) : base(CmdIds.FinishGuideReportRsp)
    {
        var proto = new FinishGuideReportRsp
        {
            IsFinish = true,
            GuideIdList = { player.GuideData!.GuideFinishList }
        };

        SetData(proto);
    }
}
