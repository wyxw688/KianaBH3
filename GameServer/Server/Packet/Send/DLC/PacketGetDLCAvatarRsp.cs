using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.DLC;

public class PacketGetDLCAvatarRsp : BasePacket
{
    public PacketGetDLCAvatarRsp() : base(CmdIds.GetDLCAvatarRsp)
    {
        var proto = new GetDLCAvatarRsp
        {
        
        };

        SetData(proto);
    }
}
