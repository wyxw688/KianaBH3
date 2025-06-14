using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Client;

public class PacketGetClientMailDataRsp : BasePacket
{
    public PacketGetClientMailDataRsp() : base(CmdIds.GetClientMailDataRsp)
    {
        var proto = new GetClientMailDataRsp
        {
        
        };

        SetData(proto);
    }
}
