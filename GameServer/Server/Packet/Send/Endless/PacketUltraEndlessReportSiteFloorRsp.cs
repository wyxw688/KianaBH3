using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Endless;

public class PacketUltraEndlessReportSiteFloorRsp : BasePacket
{
    public PacketUltraEndlessReportSiteFloorRsp(uint siteId, uint floor) : base(CmdIds.UltraEndlessReportSiteFloorRsp)
    {
        var proto = new UltraEndlessReportSiteFloorRsp
        {
            SiteId = siteId,
            Floor = floor,
        };

        SetData(proto);
    }
}
