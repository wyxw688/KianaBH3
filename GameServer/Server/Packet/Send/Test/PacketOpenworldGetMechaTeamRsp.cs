using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketOpenworldGetMechaTeamRsp : BasePacket
{
    public PacketOpenworldGetMechaTeamRsp() : base(CmdIds.OpenworldGetMechaTeamRsp)
    {
        var proto = new OpenworldGetMechaTeamRsp
        {
        
        };

        SetData(proto);
    }
}
