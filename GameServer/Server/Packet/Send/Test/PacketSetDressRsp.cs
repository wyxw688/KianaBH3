using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketSetDressRsp : BasePacket
{
    public PacketSetDressRsp() : base(CmdIds.SetDressRsp)
    {
        var proto = new SetDressRsp
        {
        
        };

        SetData(proto);
    }
}
