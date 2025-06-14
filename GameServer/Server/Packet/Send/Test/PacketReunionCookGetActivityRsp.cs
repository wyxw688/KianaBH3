using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketReunionCookGetActivityRsp : BasePacket
{
    public PacketReunionCookGetActivityRsp() : base(CmdIds.ReunionCookGetActivityRsp)
    {
        var proto = new ReunionCookGetActivityRsp
        {
        
        };

        SetData(proto);
    }
}
