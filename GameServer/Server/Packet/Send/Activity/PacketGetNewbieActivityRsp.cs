using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetNewbieActivityRsp : BasePacket
{
    public PacketGetNewbieActivityRsp() : base(CmdIds.GetNewbieActivityRsp)
    {
        var proto = new GetNewbieActivityRsp
        {
        
        };

        SetData(proto);
    }
}
