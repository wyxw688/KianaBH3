using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Armada;

public class PacketGetArmadaActivityListRsp : BasePacket
{
    public PacketGetArmadaActivityListRsp() : base(CmdIds.GetArmadaActivityListRsp)
    {
        // TODO: Hardcoded

        var proto = new GetArmadaActivityListRsp
        {
            ActivityList =
            {
                new ArmadaActivity
                {
                    BeginTime = 0,
                    EndTime = 1880308800,
                    Type = ArmadaActivityType.ArmadaActivityArmadaStageScoreActivity
                }
            }
        };

        SetData(proto);
    }
}
