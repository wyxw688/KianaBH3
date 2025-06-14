using KianaBH.Data;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Stage;

public class PacketGetStageActDifficultyRsp : BasePacket
{
    public PacketGetStageActDifficultyRsp() : base(CmdIds.GetStageActDifficultyRsp)
    {
        var proto = new GetStageActDifficultyRsp
        {
            ActDifficultyList =
            {
                GameData.ActChallengeData.Values
                .SelectMany(data => data.Select(x => new StageActDifficultyInfo
                {
                    ActId = x.ActId,
                    Difficulty = x.Difficulty,
                    HasTakeChallengeNumIndex = { 1, 2, 3 },
                }))
            }
        };   

        SetData(proto);
    }
}
