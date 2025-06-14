using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetChapterCompensationInfoRsp : BasePacket
{
    public PacketGetChapterCompensationInfoRsp() : base(CmdIds.GetChapterCompensationInfoRsp)
    {
        var proto = new GetChapterCompensationInfoRsp
        {
        
        };

        SetData(proto);
    }
}
