using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketUltraEndlessReportSiteFloorRsp : BasePacket
{
    public PacketUltraEndlessReportSiteFloorRsp() : base(CmdIds.UltraEndlessReportSiteFloorRsp)
    {
        var proto = new UltraEndlessReportSiteFloorRsp
        {
        
        };

        SetData(proto);
    }
}
