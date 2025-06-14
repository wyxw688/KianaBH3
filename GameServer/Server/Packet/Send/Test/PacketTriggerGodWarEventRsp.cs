using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketTriggerGodWarEventRsp : BasePacket
{
    public PacketTriggerGodWarEventRsp() : base(CmdIds.TriggerGodWarEventRsp)
    {
        var proto = new TriggerGodWarEventRsp
        {
        
        };

        SetData(proto);
    }
}
