using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Stage;

public class PacketGetStageChapterRsp : BasePacket
{
    public PacketGetStageChapterRsp() : base(CmdIds.GetStageChapterRsp)
    {
        var proto = new GetStageChapterRsp
        {
        
        };

        SetData(proto);
    }
}
