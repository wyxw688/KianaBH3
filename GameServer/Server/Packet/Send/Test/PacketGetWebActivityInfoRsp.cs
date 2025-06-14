using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketGetWebActivityInfoRsp : BasePacket
{
    public PacketGetWebActivityInfoRsp() : base(CmdIds.GetWebActivityInfoRsp)
    {
        var proto = new GetWebActivityInfoRsp
        {
        
        };

        SetData(proto);
    }
}
