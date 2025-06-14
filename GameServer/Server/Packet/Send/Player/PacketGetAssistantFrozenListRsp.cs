using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketGetAssistantFrozenListRsp : BasePacket
{
    public PacketGetAssistantFrozenListRsp() : base(CmdIds.GetAssistantFrozenListRsp)
    {
        var proto = new GetAssistantFrozenListRsp
        {
        
        };

        SetData(proto);
    }
}
