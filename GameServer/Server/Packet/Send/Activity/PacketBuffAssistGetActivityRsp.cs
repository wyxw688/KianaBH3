using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketBuffAssistGetActivityRsp : BasePacket
{
    public PacketBuffAssistGetActivityRsp() : base(CmdIds.BuffAssistGetActivityRsp)
    {
        var proto = new BuffAssistGetActivityRsp
        {
        
        };

        SetData(proto);
    }
}
