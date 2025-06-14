using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Client;

public class PacketClientReportRsp : BasePacket
{
    public PacketClientReportRsp() : base(CmdIds.ClientReportRsp)
    {
        var proto = new ClientReportRsp
        {
        
        };

        SetData(proto);
    }
}
