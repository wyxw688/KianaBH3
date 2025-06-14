using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetSecurityPasswordRsp : BasePacket
{
    public PacketGetSecurityPasswordRsp() : base(CmdIds.GetSecurityPasswordRsp)
    {
        var proto = new GetSecurityPasswordRsp
        {
        
        };

        SetData(proto);
    }
}
