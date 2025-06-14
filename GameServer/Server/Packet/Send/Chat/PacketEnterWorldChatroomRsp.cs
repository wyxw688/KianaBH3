using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Chat;

public class PacketEnterWorldChatroomRsp : BasePacket
{
    public PacketEnterWorldChatroomRsp() : base(CmdIds.EnterWorldChatroomRsp)
    {
        // TODO: Hardcoded
        var proto = new EnterWorldChatroomRsp
        {
            ChatroomId = 1,
            PlayerNum = 69
        };

        SetData(proto);
    }
}
