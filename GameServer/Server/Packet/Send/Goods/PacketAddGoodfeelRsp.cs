using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Goods;

public class PacketAddGoodfeelRsp : BasePacket
{
    public PacketAddGoodfeelRsp() : base(CmdIds.AddGoodfeelRsp)
    {
        var proto = new AddGoodfeelRsp
        {
        
        };

        SetData(proto);
    }
}
