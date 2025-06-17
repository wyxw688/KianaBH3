using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Endless;

public class PacketUltraEndlessEnterSiteRsp : BasePacket
{
    public PacketUltraEndlessEnterSiteRsp(uint siteId) : base(CmdIds.UltraEndlessEnterSiteRsp)
    {
        var proto = new UltraEndlessEnterSiteRsp
        {
            SiteId = siteId
        };

        SetData(proto);
    }
}
