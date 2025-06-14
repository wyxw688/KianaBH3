using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Chat;

public class PacketChatworldBeastGetActivityRsp : BasePacket
{
    public PacketChatworldBeastGetActivityRsp() : base(CmdIds.ChatworldBeastGetActivityRsp)
    {
        var proto = new ChatworldBeastGetActivityRsp
        {
        
        };

        SetData(proto);
    }
}
