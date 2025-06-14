using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketOpenworldHuntActivityGetDataRsp : BasePacket
{
    public PacketOpenworldHuntActivityGetDataRsp() : base(CmdIds.OpenworldHuntActivityGetDataRsp)
    {
        var proto = new OpenworldHuntActivityGetDataRsp
        {
        
        };

        SetData(proto);
    }
}
