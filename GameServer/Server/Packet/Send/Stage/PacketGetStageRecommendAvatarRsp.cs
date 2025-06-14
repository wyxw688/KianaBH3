using Google.Protobuf.Collections;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Stage;

public class PacketGetStageRecommendAvatarRsp : BasePacket
{
    public PacketGetStageRecommendAvatarRsp(RepeatedField<string> IdList, AvatarRecommendType Type) : base(CmdIds.GetStageRecommendAvatarRsp)
    {
        var proto = new GetStageRecommendAvatarRsp 
        {
            StageRecommendAvatarList =
            {
                IdList.Select(id => new StageRecommendAvatar
                {
                    Id = id.ToString(),
                    Type = Type
                })
            }
        };
        SetData(proto);
    }
}
