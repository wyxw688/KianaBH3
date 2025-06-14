using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.ExBoss;

public class PacketGetExBossScheduleRsp : BasePacket
{
    public PacketGetExBossScheduleRsp() : base(CmdIds.GetExBossScheduleRsp)
    {
        // TODO: Hardcoded
        var proto = new GetExBossScheduleRsp
        {
            BeginTime = 1730750400,
            EndTime = 1931268799,
            MinLevel = 38,
            RankId = 104,
            ScheduleId = 10377
        };

        SetData(proto);
    }
}
