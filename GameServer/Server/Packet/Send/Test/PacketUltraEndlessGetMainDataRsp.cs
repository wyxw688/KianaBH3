using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketUltraEndlessGetMainDataRsp : BasePacket
{
    public PacketUltraEndlessGetMainDataRsp() : base(CmdIds.UltraEndlessGetMainDataRsp)
    {
        var proto = new UltraEndlessGetMainDataRsp
        {
        
        };

        SetData(proto);
    }
}
