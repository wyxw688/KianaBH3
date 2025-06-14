using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketRaidReplaceGetDataRsp : BasePacket
{
    public PacketRaidReplaceGetDataRsp() : base(CmdIds.RaidReplaceGetDataRsp)
    {
        var proto = new RaidReplaceGetDataRsp
        {
        
        };

        SetData(proto);
    }
}
