using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketArkPlusActivityGetDataRsp : BasePacket
{
    public PacketArkPlusActivityGetDataRsp() : base(CmdIds.ArkPlusActivityGetDataRsp)
    {
        var proto = new ArkPlusActivityGetDataRsp
        {
        
        };

        SetData(proto);
    }
}
