using KianaBH.Data;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Challenge;

public class PacketGetChallengeStepCompensationInfoRsp : BasePacket
{
    public PacketGetChallengeStepCompensationInfoRsp() : base(CmdIds.GetChallengeStepCompensationInfoRsp)
    {
        var proto = new GetChallengeStepCompensationInfoRsp 
        { 
            CompensationList =
            {
                GameData.StepMissionCompensationData.Values
                    .Select(m => new ChallengeStepCompensation
                    {
                        CompensationId = m.CompensationId,
                        IsTakeCompensation = true,
                        NewChallengeStepCompensationList =
                        {
                            m.NewChallengeStepIdList.Select(id => new StepCompensation { StepId = id })
                        },
                        OldChallengeStepCompensationList =
                        {
                            m.OldChallengeStepIdList.Select(id => new StepCompensation { StepId = id })
                        },
                        MainlineStepCompensationList =
                        {
                            m.MainLineStepIdList.Select(id => new StepCompensation { StepId = id })
                        },
                    })
            }
        };

        SetData(proto);
    }
}
