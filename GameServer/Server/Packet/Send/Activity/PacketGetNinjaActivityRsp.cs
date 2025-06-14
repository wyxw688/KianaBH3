using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetNinjaActivityRsp : BasePacket
{
    public PacketGetNinjaActivityRsp() : base(CmdIds.GetNinjaActivityRsp)
    {
        var proto = new GetNinjaActivityRsp
        {
        
        };

        SetData(proto);
    }
}
