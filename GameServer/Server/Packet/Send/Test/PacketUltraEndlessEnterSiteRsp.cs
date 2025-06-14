using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketUltraEndlessEnterSiteRsp : BasePacket
{
    public PacketUltraEndlessEnterSiteRsp() : base(CmdIds.UltraEndlessEnterSiteRsp)
    {
        var proto = new UltraEndlessEnterSiteRsp
        {
        
        };

        SetData(proto);
    }
}
