using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketSimplifiedGodWarGetActivityRsp : BasePacket
{
    public PacketSimplifiedGodWarGetActivityRsp() : base(CmdIds.SimplifiedGodWarGetActivityRsp)
    {
        var proto = new SimplifiedGodWarGetActivityRsp
        {
        
        };

        SetData(proto);
    }
}
