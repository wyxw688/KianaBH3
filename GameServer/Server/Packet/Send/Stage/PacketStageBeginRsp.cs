using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Stage;

public class PacketStageBeginRsp : BasePacket
{
    public PacketStageBeginRsp(uint StageId) : base(CmdIds.StageBeginRsp)
    {
        var proto = new StageBeginRsp
        {
            StageId = StageId
        };

        SetData(proto);
    }
}
