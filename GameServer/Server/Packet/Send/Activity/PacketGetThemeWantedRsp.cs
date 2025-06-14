using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetThemeWantedRsp : BasePacket
{
    public PacketGetThemeWantedRsp() : base(CmdIds.GetThemeWantedRsp)
    {
        // TODO: Hardcoded

        var proto = new GetThemeWantedRsp
        {
            ThemeWantedActivity = new ThemeWantedActivity
            {
                ActivityId = 11105,
                OpenStageGroupIdList = { 17, 18, 19, 20 },
                ScheduleId = 5,
                StageGroupInfoList =
                {
                    new ThemeWantedStageGroupInfo
                    {
                        Progress = 8,
                        StageGroupId = 17
                    },
                    new ThemeWantedStageGroupInfo
                    {
                        NotPassProgressList = { 7 },
                        Progress = 7,
                        StageGroupId = 18
                    },
                    new ThemeWantedStageGroupInfo
                    {
                        Progress = 8,
                        StageGroupId = 19
                    },
                    new ThemeWantedStageGroupInfo
                    {
                        Progress = 8,
                        StageGroupId = 20
                    },
                }
            }
        };

        SetData(proto);
    }
}
