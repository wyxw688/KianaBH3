using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetRaffleActivityRsp : BasePacket
{
    public PacketGetRaffleActivityRsp() : base(CmdIds.GetRaffleActivityRsp)
    {
        var proto = new GetRaffleActivityRsp
        {
        
        };

        SetData(proto);
    }
}
