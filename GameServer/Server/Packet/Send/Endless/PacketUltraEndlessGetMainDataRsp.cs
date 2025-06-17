using KianaBH.Data;
using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;
using KianaBH.Util.Extensions;

namespace KianaBH.GameServer.Server.Packet.Send.Endless;

public class PacketUltraEndlessGetMainDataRsp : BasePacket
{
    public PacketUltraEndlessGetMainDataRsp(PlayerInstance player) : base(CmdIds.UltraEndlessGetMainDataRsp)
    {
        uint cupNum = player.Data.GetCupNum();
        var proto = new UltraEndlessGetMainDataRsp
        {
            ScheduleId = 1028,
            GroupLevel = (uint)player.Data.Abyss.GroupLevel,
            TopGroupLevel = 9,
            CupNum = cupNum,
            MainData = new UltraEndlessMainData
            {
                ScheduleId = 1028,
                BeginTime = (uint)Extensions.GetUnixSec(),
                EndTime = (uint)Extensions.GetUnixSec() + 3600 * 24 * 7,
                CloseTime = (uint)Extensions.GetUnixSec() + 3600 * 24 * 7 + 1200,
                CurSeasonId = 1,
                SiteList = { player.Data.ToUltraEndlessSiteProto() }
            },
            DynamicHardLevel = (uint)player.Data.Abyss.DynamicHard,
            EndlessPlayerList =
            {
                new UltraEndlessPlayer
                {
                    Uid = (uint)player.Data.Uid,
                    GroupLevel = (uint)player.Data.Abyss.GroupLevel,
                    CupNum = cupNum,
                    MaxStageScore = 18000
                }
            },
            BriefDataList =
            {
                new PlayerFriendBriefData
                {
                    Uid = (uint)player.Data.Uid,
                    Nickname = player.Data.Name,
                    Level = (uint)player.Data.Level,
                }
            },
            LastSettleInfo = new UltraEndlessSettleInfo
            {
                CupNum = 280,
                CupNumAfterScheduleSettle = 280,
                CupNumAfterSeasonSettle = 380,
                CupNumBefore = 380,
                CupNumBeforeSeasonSettle = 380,
                GroupLevel = 3,
                GroupMemberNum = 20,
                MmrScore = 974,
                Rank = 20,
                ScheduleId = 3426
            },
        };

        SetData(proto);
    }
}
