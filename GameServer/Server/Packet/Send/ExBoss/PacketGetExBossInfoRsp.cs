using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.ExBoss;

public class PacketGetExBossInfoRsp : BasePacket
{
    public PacketGetExBossInfoRsp(PlayerInstance player) : base(CmdIds.GetExBossInfoRsp)
    {
        var proto = new GetExBossInfoRsp
        {
            BossInfo = new ExBossInfo
            {
                BossIdList = 
                {
                    player.Data.ExBossMonster.Select(x => new ExBossIdInfo
                    {
                        BossId = (uint)x
                    })
                },
                CurMaxEnterTimes = 36,
                NowScheduleId = 10407,
                RankId = 104,
                ScheduleId = 10407
            }
        };

        SetData(proto);
    }
}
