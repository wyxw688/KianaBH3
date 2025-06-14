using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetShoppingMallListRsp : BasePacket
{
    public PacketGetShoppingMallListRsp() : base(CmdIds.GetShoppingMallListRsp)
    {
        var proto = new GetShoppingMallListRsp
        {
        
        };

        SetData(proto);
    }
}
