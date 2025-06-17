using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.ExBoss;

public class PacketGetExBossRankRsp : BasePacket
{
    public PacketGetExBossRankRsp(PlayerInstance player, uint bossId, uint rankId) : base(CmdIds.GetExBossRankRsp)
    {
        // TODO: Hardcoded
        var proto = new GetExBossRankRsp
        {
            BossId = bossId,
            RankId = rankId,
            RankData = new RankShowData
            {
                MyRank = 1,
                MyRankType = 1
            }
        };

        SetData(proto);
    }
}
