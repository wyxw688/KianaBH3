using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetProductRecommendListRsp : BasePacket
{
    public PacketGetProductRecommendListRsp() : base(CmdIds.GetProductRecommendListRsp)
    {
        var proto = new GetProductRecommendListRsp
        {
            RecommendList =
            {
                16301720
            }
        };

        SetData(proto);
    }
}
