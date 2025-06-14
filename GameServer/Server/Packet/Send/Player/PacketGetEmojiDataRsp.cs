using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketGetEmojiDataRsp : BasePacket
{
    public PacketGetEmojiDataRsp() : base(CmdIds.GetEmojiDataRsp)
    {
        var proto = new GetEmojiDataRsp
        {
            IsAll = true
        };

        SetData(proto);
    }
}
