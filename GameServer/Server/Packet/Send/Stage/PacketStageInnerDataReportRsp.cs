using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Stage;

public class PacketStageInnerDataReportRsp : BasePacket
{
    public PacketStageInnerDataReportRsp() : base(CmdIds.StageInnerDataReportRsp)
    {
        var proto = new StageInnerDataReportRsp
        {
        
        };

        SetData(proto);
    }
}
