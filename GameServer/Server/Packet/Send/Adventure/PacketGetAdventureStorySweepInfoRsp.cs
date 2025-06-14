using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Adventure;

public class PacketGetAdventureStorySweepInfoRsp : BasePacket
{
    public PacketGetAdventureStorySweepInfoRsp() : base(CmdIds.GetAdventureStorySweepInfoRsp)
    {
        // TODO: Hardcoded

        var proto = new GetAdventureStorySweepInfoRsp
        {
            StorySweepList =
            {
                new IslandStorySweepData
                {
                    AvatarIdList =
                    {
                        20401,
                        20301,
                        20201
                    },
                    IsFinished = true,
                    OverTime = 1719938652,
                    SweepId = 282
                },
                new IslandStorySweepData
                {
                    AvatarIdList =
                    {
                        3701,
                        3601,
                        3501
                    },
                    IsFinished = true,
                    OverTime = 1719938654,
                    SweepId = 282
                },
                new IslandStorySweepData
                {
                    AvatarIdList =
                    {
                        3301,
                        3201,
                        3101
                    },
                    IsFinished = true,
                    OverTime = 1719938655,
                    SweepId = 282
                }
            }
        };

        SetData(proto);
    }
}
