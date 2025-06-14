using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Chat;

public class PacketChatworldGetPrayInfoRsp : BasePacket
{
    public PacketChatworldGetPrayInfoRsp() : base(CmdIds.ChatworldGetPrayInfoRsp)
    {
        var proto = new ChatworldGetPrayInfoRsp
        {
        
        };

        SetData(proto);
    }
}
