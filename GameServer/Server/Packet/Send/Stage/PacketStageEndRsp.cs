using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Stage;

public class PacketStageEndRsp : BasePacket
{
    public PacketStageEndRsp(uint StageId, StageEndStatus EndStatus) : base(CmdIds.StageEndRsp)
    {
        var proto = new StageEndRsp
        {
            StageId = StageId,
            EndStatus = EndStatus
        };

        SetData(proto);
    }
}
