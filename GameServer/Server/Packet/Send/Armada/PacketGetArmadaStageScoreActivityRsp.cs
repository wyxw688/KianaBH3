using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Armada;

public class PacketGetArmadaStageScoreActivityRsp : BasePacket
{
    public PacketGetArmadaStageScoreActivityRsp() : base(CmdIds.GetArmadaStageScoreActivityRsp)
    {
        var proto = new GetArmadaStageScoreActivityRsp
        {
        
        };

        SetData(proto);
    }
}
