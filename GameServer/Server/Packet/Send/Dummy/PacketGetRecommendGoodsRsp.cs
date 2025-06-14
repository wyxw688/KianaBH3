using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetRecommendGoodsRsp : BasePacket
{
    public PacketGetRecommendGoodsRsp() : base(CmdIds.GetRecommendGoodsRsp)
    {
        var proto = new GetRecommendGoodsRsp
        {
        
        };

        SetData(proto);
    }
}
