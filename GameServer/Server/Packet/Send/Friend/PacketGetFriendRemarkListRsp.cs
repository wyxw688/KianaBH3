using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Friend;

public class PacketGetFriendRemarkListRsp : BasePacket
{
    public PacketGetFriendRemarkListRsp() : base(CmdIds.GetFriendRemarkListRsp)
    {
        var proto = new GetFriendRemarkListRsp
        {
        
        };

        SetData(proto);
    }
}
