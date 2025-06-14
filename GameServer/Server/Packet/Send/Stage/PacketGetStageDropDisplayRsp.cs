using Google.Protobuf.Collections;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Stage;

public class PacketGetStageDropDisplayRsp : BasePacket
{
    public PacketGetStageDropDisplayRsp(RepeatedField<uint> StageIdList) : base(CmdIds.GetStageDropDisplayRsp)
    {
        var proto = new GetStageDropDisplayRsp 
        {
            StageDropList =
            {
                StageIdList.Select(id => new StageDropDisplayInfo
                {
                    StageId = id
                })
            }
        };

        SetData(proto);
    }
}
