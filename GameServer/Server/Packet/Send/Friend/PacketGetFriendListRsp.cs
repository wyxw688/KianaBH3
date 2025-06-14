using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Friend;

public class PacketGetFriendListRsp : BasePacket
{
    public PacketGetFriendListRsp() : base(CmdIds.GetFriendListRsp)
    {
        var proto = new GetFriendListRsp
        {
        
        };

        SetData(proto);
    }
}
