using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetTradingCardActivityRsp : BasePacket
{
    public PacketGetTradingCardActivityRsp() : base(CmdIds.GetTradingCardActivityRsp)
    {
        var proto = new GetTradingCardActivityRsp
        {
        
        };

        SetData(proto);
    }
}
