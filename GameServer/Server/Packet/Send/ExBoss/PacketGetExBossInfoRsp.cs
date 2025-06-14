using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.ExBoss;

public class PacketGetExBossInfoRsp : BasePacket
{
    public PacketGetExBossInfoRsp() : base(CmdIds.GetExBossInfoRsp)
    {
        // TODO:Hardcoded

        var proto = new GetExBossInfoRsp
        {
            BossInfo = new ExBossInfo
            {
                BossIdList = { },
                CurMaxEnterTimes = 18,
                RankId = 104,
                ScheduleId = 10377,
                NowScheduleId = 10377
            }
        };

        SetData(proto);
    }
}
