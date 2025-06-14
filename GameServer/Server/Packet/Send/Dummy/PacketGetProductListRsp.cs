using KianaBH.KcpSharp;
using KianaBH.Proto;
using KianaBH.Util.Extensions;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetProductListRsp : BasePacket
{
    public PacketGetProductListRsp() : base(CmdIds.GetProductListRsp)
    {
        var time = (uint)Extensions.GetUnixSec();

        var proto = new GetProductListRsp
        {
            NextRandomBoxProductRefreshTime = time + 3600 * 24,
            NextLimitProductRefreshTime = time + 3600 * 24
        };

        SetData(proto);
    }
}
