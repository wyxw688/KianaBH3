using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.DLC;

public class PacketGetDLCRsp : BasePacket
{
    public PacketGetDLCRsp() : base(CmdIds.GetDLCRsp)
    {
        var proto = new GetDLCRsp
        {
        
        };

        SetData(proto);
    }
}
