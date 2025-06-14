using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetExtractReforgeActivityRsp : BasePacket
{
    public PacketGetExtractReforgeActivityRsp() : base(CmdIds.GetExtractReforgeActivityRsp)
    {
        var proto = new GetExtractReforgeActivityRsp
        {
        
        };

        SetData(proto);
    }
}
