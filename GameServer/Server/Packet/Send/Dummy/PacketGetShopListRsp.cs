using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetShopListRsp : BasePacket
{
    public PacketGetShopListRsp() : base(CmdIds.GetShopListRsp)
    {
        var proto = new GetShopListRsp
        {
            IsAll = true,
        };

        SetData(proto);
    }
}
