using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Pjms;

public class PacketPjmsGetConditionDataRsp : BasePacket
{
    public PacketPjmsGetConditionDataRsp() : base(CmdIds.PjmsGetConditionDataRsp)
    {
        var proto = new PjmsGetConditionDataRsp
        {
        
        };

        SetData(proto);
    }
}
