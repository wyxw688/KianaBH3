using Google.Protobuf.Collections;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGeneralActivityGetScoreRewardInfoRsp : BasePacket
{
    public PacketGeneralActivityGetScoreRewardInfoRsp(RepeatedField<uint> ActivityIdList) : base(CmdIds.GeneralActivityGetScoreRewardInfoRsp)
    {
        var proto = new GeneralActivityGetScoreRewardInfoRsp
        {
            ScoreInfoList = 
            {
                ActivityIdList?.Select(id => new GeneralActivityScoreRewardInfo
                {
                    ActivityId = id,
                    CurScore = 0
                })
            }
        };

        SetData(proto);
    }
}
