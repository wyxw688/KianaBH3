using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetRecommendFriendListRsp : BasePacket
{
    public PacketGetRecommendFriendListRsp() : base(CmdIds.GetRecommendFriendListRsp)
    {
        var proto = new GetRecommendFriendListRsp
        {
        
        };

        SetData(proto);
    }
}
