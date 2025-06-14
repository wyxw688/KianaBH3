using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketUltraEndlessGetTopRankRsp : BasePacket
{
    public PacketUltraEndlessGetTopRankRsp() : base(CmdIds.UltraEndlessGetTopRankRsp)
    {
        var proto = new UltraEndlessGetTopRankRsp
        {
        
        };

        SetData(proto);
    }
}
