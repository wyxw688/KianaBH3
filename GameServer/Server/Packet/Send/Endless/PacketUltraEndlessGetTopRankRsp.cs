using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Endless;

public class PacketUltraEndlessGetTopRankRsp : BasePacket
{
    public PacketUltraEndlessGetTopRankRsp(PlayerInstance player, uint scheduleId) : base(CmdIds.UltraEndlessGetTopRankRsp)
    {
        var proto = new UltraEndlessGetTopRankRsp
        {
            ScheduleId = scheduleId,
            RankData = new RankShowData
            {
                IsFeatureClosed = true,
                MyRank = 1,
                MyRankType = 1,
                MyScore = 18000,
                RankList =
                {
                    new UserRankData
                    {
                        Uid = (uint)player.Data.Uid,
                        NickName = player.Data.Name,
                        Rank = 1,
                        Score = 18000,
                        CustomHeadId = (uint)player.Data.HeadIcon,
                        FrameId = (uint)player.Data.HeadFrame,
                    }
                }
            },
        };

        SetData(proto);
    }
}
