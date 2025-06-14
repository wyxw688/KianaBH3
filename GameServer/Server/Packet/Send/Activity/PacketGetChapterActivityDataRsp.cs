using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetChapterActivityDataRsp : BasePacket
{
    public PacketGetChapterActivityDataRsp() : base(CmdIds.GetChapterActivityDataRsp)
    {
        var proto = new GetChapterActivityDataRsp
        {
        
        };

        SetData(proto);
    }
}
