using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Friend;

public class PacketGetAskAddFriendListRsp : BasePacket
{
    public PacketGetAskAddFriendListRsp() : base(CmdIds.GetAskAddFriendListRsp)
    {
        var proto = new GetAskAddFriendListRsp
        {
        
        };

        SetData(proto);
    }
}
