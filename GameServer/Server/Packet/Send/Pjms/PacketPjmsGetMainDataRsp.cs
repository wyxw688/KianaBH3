using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Pjms;

public class PacketPjmsGetMainDataRsp : BasePacket
{
    public PacketPjmsGetMainDataRsp() : base(CmdIds.PjmsGetMainDataRsp)
    {
        var proto = new PjmsGetMainDataRsp
        {
        
        };

        SetData(proto);
    }
}
