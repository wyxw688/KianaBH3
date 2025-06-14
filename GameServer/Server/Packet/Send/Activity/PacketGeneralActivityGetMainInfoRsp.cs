using Google.Protobuf.Collections;
using KianaBH.Data;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGeneralActivityGetMainInfoRsp : BasePacket
{
    public PacketGeneralActivityGetMainInfoRsp(RepeatedField<uint> ActivityIdList) : base(CmdIds.GeneralActivityGetMainInfoRsp)
    {
        var activityList = ActivityIdList.Select(activityId =>
        {
            GameData.GeneralActivityData
                .TryGetValue((int)activityId, out var series);

            var activity = new GeneralActivity
            {
                GeneralBasicInfo = new GeneralActivityBasicInfo
                {
                    ActivityId = activityId,
                    ScheduleId = series?.Series ?? 0,
                    SeriesActivityId ={ activityId }
                }
            };

            GameData.GeneralActivityStageGroupData
                .TryGetValue((int)activityId, out var activityStage);

            if (activityStage != null)
            {
                activity.ActivityStage = new GeneralActivityStage
                {
                    StageGroupScheduleList =
                    {
                        activityStage.Select(x => new GeneralActivityStageGroupScheduleInfo
                        {
                            BeginTime = 1593223200,
                            EndTime = 1913140799,
                            StageGroupId = x.StageGroupId
                        })
                        
                    }
                };
            }
            return activity;
        });

        var proto = new GeneralActivityGetMainInfoRsp 
        { 
            ActivityList = { activityList }
        };

        SetData(proto);
    }
}



//using Google.Protobuf.Collections;
//using KianaBH.Data;
//using KianaBH.KcpSharp;
//using KianaBH.Proto;
//using KianaBH.Util.Extensions;

//namespace KianaBH.GameServer.Server.Packet.Send.Activity;

//public class PacketGeneralActivityGetMainInfoRsp : BasePacket
//{
//    public PacketGeneralActivityGetMainInfoRsp(RepeatedField<uint> ActivityIdList) : base(CmdIds.GeneralActivityGetMainInfoRsp)
//    {
//        var proto = new GeneralActivityGetMainInfoRsp();

//        foreach (var Id in ActivityIdList)
//        {
//            var ActivityData = GameData.GeneralActivityData.TryGetValue((int)Id, out var Data);
//            var Activity = new GeneralActivity
//            {
//                GeneralBasicInfo = new GeneralActivityBasicInfo
//                {
//                    ActivityId = Id,
//                    ScheduleId =  Data!.Series,
//                    SeriesActivityId = { Id },
//                }
//            };
//            var GeneralStageData = GameData.GeneralActivityStageGroupData.TryGetValue((int)Id, out var StageData);
//            if (StageData != null)
//            {
//                Activity.ActivityStage = new GeneralActivityStage
//                {
//                    StageGroupScheduleList =
//                    {
//                        StageData.Select(x => new GeneralActivityStageGroupScheduleInfo
//                        {
//                            BeginTime = (uint)Extensions.GetUnixSec(),
//                            EndTime = (uint)Extensions.GetUnixSec() + 1800,
//                            StageGroupId = x.StageGroupID
//                        })
//                    }
//                };
//            }
//            proto.ActivityList.Add(Activity);
//        }

//        SetData(proto);
//    }
//}
