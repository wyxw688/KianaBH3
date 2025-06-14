using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketWaveRushGetActivityRsp : BasePacket
{
    public PacketWaveRushGetActivityRsp() : base(CmdIds.WaveRushGetActivityRsp)
    {
        var proto = new WaveRushGetActivityRsp
        {
        
        };

        SetData(proto);
    }
}
