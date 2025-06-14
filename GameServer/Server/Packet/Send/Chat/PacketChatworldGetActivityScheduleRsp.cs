using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Chat;

public class PacketChatworldGetActivityScheduleRsp : BasePacket
{
    public PacketChatworldGetActivityScheduleRsp() : base(CmdIds.ChatworldGetActivityScheduleRsp)
    {
        // TODO: Hardcoded

        var proto = new ChatworldGetActivityScheduleRsp
        {
            SceneId = 111
        };

        SetData(proto);
    }
}
