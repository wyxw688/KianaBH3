using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Chat;

public class PacketGetChatgroupListRsp : BasePacket
{
    public PacketGetChatgroupListRsp() : base(CmdIds.GetChatgroupListRsp)
    {
        var proto = new GetChatgroupListRsp
        {
        
        };

        SetData(proto);
    }
}
