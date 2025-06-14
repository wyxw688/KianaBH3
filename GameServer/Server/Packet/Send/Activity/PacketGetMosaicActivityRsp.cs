using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetMosaicActivityRsp : BasePacket
{
    public PacketGetMosaicActivityRsp() : base(CmdIds.GetMosaicActivityRsp)
    {
        var proto = new GetMosaicActivityRsp
        {
        
        };

        SetData(proto);
    }
}
