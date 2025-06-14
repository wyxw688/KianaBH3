using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Client;

public class PacketReportClientDataVersionRsp : BasePacket
{
    public PacketReportClientDataVersionRsp(uint version) : base(CmdIds.ReportClientDataVersionRsp)
    {
        var proto = new ReportClientDataVersionRsp
        {
            ServerVersion = version
        };

        SetData(proto);
    }
}
