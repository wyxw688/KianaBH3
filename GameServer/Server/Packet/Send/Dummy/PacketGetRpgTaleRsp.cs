using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetRpgTaleRsp : BasePacket
{
    public PacketGetRpgTaleRsp() : base(CmdIds.GetRpgTaleRsp)
    {
        var proto = new GetRpgTaleRsp
        {
        
        };

        SetData(proto);
    }
}
