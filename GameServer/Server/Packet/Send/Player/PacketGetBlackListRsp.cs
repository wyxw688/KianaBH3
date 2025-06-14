using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketGetBlackListRsp : BasePacket
{
    public PacketGetBlackListRsp() : base(CmdIds.GetBlackListRsp)
    {
        var proto = new GetBlackListRsp
        {
        
        };

        SetData(proto);
    }
}
