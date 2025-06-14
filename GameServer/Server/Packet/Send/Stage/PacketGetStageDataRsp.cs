using Google.Protobuf.Collections;
using KianaBH.Data;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Stage;

public class PacketGetStageDataRsp : BasePacket
{
    public PacketGetStageDataRsp(RepeatedField<uint> StageIdList) : base(CmdIds.GetStageDataRsp)
    {
        var isAll = StageIdList.Count == 1 && StageIdList[0] == 0;

        var stageData = GameData.StageDataMain;

        var stageList = isAll
            ? stageData.Values.Select(stage => new Proto.Stage
            {
                Id = stage.LevelId,
                Progress = 1,
                ChallengeIndexList =
                {
                    stage.ChallengeList.Count == 3
                        ? new uint[] { 0, 1, 2 }
                        : new uint[] { 0 }
                },
                IsDone = true,
                MaxRank = 1
            })
            : stageData.Values
                .Where(stage => StageIdList.Contains(stage.LevelId))
                .Select(stage => new Proto.Stage
                {
                    Id = stage.LevelId,
                    Progress = 1,
                    ChallengeIndexList =
                    {
                        stage.ChallengeList.Count == 3
                            ? new uint[] { 0, 1, 2 }
                            : new uint[] { 0 }
                    },
                    IsDone = true,
                    MaxRank = 1
                });

        var proto = new GetStageDataRsp
        {
            IsAll = isAll,
            FinishedChapterList = { Enumerable.Range(1, 43).Select(i => (uint)i) },
            EventDataList =
            {
                new StageEventData
                {
                    BeginTime = 1729108800,
                    EndTime = 1990911600,
                    ChapterId = 200,
                    UnlockLevel = 30
                }
            },
            StageList = {  }
        };

        SetData(proto);
    }
}

//using Google.Protobuf.Collections;
//using KianaBH.Data;
//using KianaBH.KcpSharp;
//using KianaBH.Proto;

//namespace KianaBH.GameServer.Server.Packet.Send.Stage;

//public class PacketGetStageDataRsp : BasePacket
//{
//    public PacketGetStageDataRsp() : base(CmdIds.GetStageDataRsp)
//    {
//        var proto = new GetStageDataRsp
//        {
//            IsAll = true,
//            FinishedChapterList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 36, 43 },
//        };

//        foreach (var data in GameData.StageDataMain.Values)
//        {
//            var stage = new Proto.Stage
//            {
//                Id = data.LevelId,
//                Progress = 1,
//                IsDone = true,
//                MaxRank = 1,
//            };

//            stage.ChallengeIndexList.AddRange(
//                data.ChallengeList.Count == 3
//                    ? new[] { 0, 1, 2 }.Select(x => (uint)x)
//                    : new[] { 0 }.Select(x => (uint)x)
//            );

//            proto.StageList.Add(stage);
//        }

//        SetData(proto);
//    }
//}