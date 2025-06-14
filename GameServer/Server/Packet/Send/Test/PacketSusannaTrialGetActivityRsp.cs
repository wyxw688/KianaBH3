using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketSusannaTrialGetActivityRsp : BasePacket
{
    public PacketSusannaTrialGetActivityRsp() : base(CmdIds.SusannaTrialGetActivityRsp)
    {
        var proto = new SusannaTrialGetActivityRsp
        {
        
        };

        SetData(proto);
    }
}
