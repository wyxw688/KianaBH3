using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Pjms;

public class PacketPjmsGetStoryDataRsp : BasePacket
{
    public PacketPjmsGetStoryDataRsp() : base(CmdIds.PjmsGetStoryDataRsp)
    {
        var proto = new PjmsGetStoryDataRsp
        {
        
        };

        SetData(proto);
    }
}
