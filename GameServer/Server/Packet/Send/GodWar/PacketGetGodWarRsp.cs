using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.GodWar;

public class PacketGetGodWarRsp : BasePacket
{
    public PacketGetGodWarRsp() : base(CmdIds.GetGodWarRsp)
    {
        // TODO: Implement
        var proto = new GetGodWarRsp
        {
        
        };

        SetData(proto);
    }
}
