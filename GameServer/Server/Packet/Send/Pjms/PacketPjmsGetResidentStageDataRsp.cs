using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Pjms;

public class PacketPjmsGetResidentStageDataRsp : BasePacket
{
    public PacketPjmsGetResidentStageDataRsp() : base(CmdIds.PjmsGetResidentStageDataRsp)
    {
        var proto = new PjmsGetResidentStageDataRsp
        {
        
        };

        SetData(proto);
    }
}
