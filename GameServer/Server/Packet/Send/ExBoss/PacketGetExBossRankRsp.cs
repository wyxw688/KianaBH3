using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.ExBoss;

public class PacketGetExBossRankRsp : BasePacket
{
    public PacketGetExBossRankRsp(PlayerInstance player) : base(CmdIds.GetExBossRankRsp)
    {
        // TODO: Hardcoded
        var proto = new GetExBossRankRsp
        {
            RankId = 104,
            RankData = new RankShowData
            {
                MyRank = 104,
                MyRankType = 2,
                MyScore = 116330,
                RankList =
                {
                    new UserRankData
                    {
                        AvatarId = 3101,
                        CustomHeadId = 161099,
                        DressId = 50217,
                        FrameId = 200080,
                        NickName = "Kiana",
                        Rank = 1,
                        Score = 119727,
                        Uid = (uint)player.Data.Uid
                    }
                }
            }
        };

        SetData(proto);
    }
}
