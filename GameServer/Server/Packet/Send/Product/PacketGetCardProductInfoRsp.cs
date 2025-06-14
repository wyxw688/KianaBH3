using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Product;

public class PacketGetCardProductInfoRsp : BasePacket
{
    public PacketGetCardProductInfoRsp() : base(CmdIds.GetCardProductInfoRsp)
    {
        var proto = new GetCardProductInfoRsp
        {
        
        };

        SetData(proto);
    }
}
