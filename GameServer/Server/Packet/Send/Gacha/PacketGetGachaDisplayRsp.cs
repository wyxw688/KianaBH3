using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Gacha;

public class PacketGetGachaDisplayRsp : BasePacket
{
    public PacketGetGachaDisplayRsp() : base(CmdIds.GetGachaDisplayRsp)
    {
        var proto = new GetGachaDisplayRsp
        {
        
        };

        SetData(proto);
    }
}
