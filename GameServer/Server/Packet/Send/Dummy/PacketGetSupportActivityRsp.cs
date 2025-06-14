using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetSupportActivityRsp : BasePacket
{
    public PacketGetSupportActivityRsp() : base(CmdIds.GetSupportActivityRsp)
    {
        var proto = new GetSupportActivityRsp
        {
        
        };

        SetData(proto);
    }
}
