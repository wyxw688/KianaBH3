using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketSetWarshipRsp : BasePacket
{
    public PacketSetWarshipRsp() : base(CmdIds.SetWarshipRsp)
    {
        var proto = new SetWarshipRsp
        {
        
        };

        SetData(proto);
    }
}
