using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Adventure;

public class PacketGetConsignedOrderDataRsp : BasePacket
{
    public PacketGetConsignedOrderDataRsp() : base(CmdIds.GetConsignedOrderDataRsp)
    {
        var proto = new GetConsignedOrderDataRsp
        {
        
        };

        SetData(proto);
    }
}
