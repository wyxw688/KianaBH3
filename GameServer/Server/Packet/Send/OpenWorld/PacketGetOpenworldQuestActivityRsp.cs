using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.OpenWorld;

public class PacketGetOpenworldQuestActivityRsp : BasePacket
{
    public PacketGetOpenworldQuestActivityRsp() : base(CmdIds.GetOpenworldQuestActivityRsp)
    {
        var proto = new GetOpenworldQuestActivityRsp
        {
        
        };

        SetData(proto);
    }
}
