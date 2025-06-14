using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.OpenWorld;

public class PacketGetNewOpenworldRsp : BasePacket
{
    public PacketGetNewOpenworldRsp() : base(CmdIds.GetNewOpenworldRsp)
    {
        // TODO: Hardcoded
        var proto = new GetNewOpenworldRsp
        {
            MapList =
            {
                new OpenworldMapBriefData
                {
                  Cycle= 4,
                  HasTakeFinishRewardCycle= 4,
                  IsOnceUnlocked= true,
                  MapId= 1,
                  QuestLevel= 30
                },
                new OpenworldMapBriefData
                {
                  Cycle= 14,
                  HasTakeFinishRewardCycle= 14,
                  IsOnceUnlocked= true,
                  MapId= 2,
                  QuestLevel= 30
                },
                new OpenworldMapBriefData
                {
                  IsOnceUnlocked= true,
                  MapId= 301,
                  QuestLevel= 30,
                  Status= 2
                },
                new OpenworldMapBriefData
                {
                  Cycle= 41,
                  IsOnceUnlocked= true,
                  MapId= 401,
                  QuestLevel= 30
                },
                new OpenworldMapBriefData
                {
                  Cycle= 61,
                  IsOnceUnlocked= true,
                  MapId= 601,
                  QuestLevel= 30
                },
                new OpenworldMapBriefData
                {
                  Cycle= 71,
                  IsOnceUnlocked= true,
                  MapId= 701,
                  QuestLevel= 30,
                  Status= 2
                },
                new OpenworldMapBriefData
                {
                  Cycle= 81,
                  MapId= 801,
                  QuestLevel= 30,
                  Status= 2
                },
                new OpenworldMapBriefData
                {
                  Cycle= 101,
                  MapId= 1001,
                  QuestLevel= 30,
                  Status= 2
                }
            },
            CloseTime = 1749409200,
            GlobalRandomSeed = 1187592820,
            MaxQuestLevel = 30,
            NextRefreshTime = 1749412800,
            QuestLevel = 30,
            QuestStar = 6,
            QuestThemeIndex = 8679,
            Tech =
            {
                new OpenworldTechData
                {
                    Exp= 17940,
                    Level= 27,
                    MapId= 1,
                    NextCollectTime= 82800,
                    UnlockSkillList= {
                    1,
                    2,
                    10,
                    11,
                    8,
                    3,
                    12,
                    7,
                    4,
                    13,
                    5,
                    14,
                    6
                    }
                },
                new OpenworldTechData
                {
                    Exp= 60500,
                    Level= 20,
                    MapId= 2,
                    NextCollectTime= 82800,
                    UnlockSkillList= {
                    101,
                    104,
                    301,
                    102,
                    302,
                    304,
                    305,
                    307,
                    308,
                    309,
                    103,
                    303,
                    306,
                    201,
                    203,
                    204,
                    206,
                    207,
                    209,
                    202,
                    210,
                    205,
                    208,
                    310
                    }
                },
                new OpenworldTechData
                {
                    MapId= 301
                },
                new OpenworldTechData
                {
                    MapId= 401
                },
                new OpenworldTechData
                {
                    MapId= 601
                },
                new OpenworldTechData
                {
                    MapId= 701
                },
                new OpenworldTechData
                {
                    MapId= 801
                },
                new OpenworldTechData
                {
                    MapId= 1001
                }
            }
        };

        SetData(proto);
    }
}
