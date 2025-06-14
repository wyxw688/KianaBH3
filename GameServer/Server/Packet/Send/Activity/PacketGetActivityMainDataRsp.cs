using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetActivityMainDataRsp : BasePacket
{
    public PacketGetActivityMainDataRsp() : base(CmdIds.GetActivityMainDataRsp)
    {
        var proto = new GetActivityMainDataRsp
        {
            ActivityModuleTypeList = { Enumerable.Range(1, 72).Select(i => (uint)i) }
        };

        SetData(proto);
    }
}
