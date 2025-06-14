using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.GodWar;

public class PacketGetGobackRsp : BasePacket
{
    public PacketGetGobackRsp() : base(CmdIds.GetGobackRsp)
    {
        var proto = new GetGobackRsp
        {
        
        };

        SetData(proto);
    }
}
