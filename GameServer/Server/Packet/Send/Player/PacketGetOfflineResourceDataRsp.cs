using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketGetOfflineResourceDataRsp : BasePacket
{
    public PacketGetOfflineResourceDataRsp() : base(CmdIds.GetOfflineResourceDataRsp)
    {
        var proto = new GetOfflineResourceDataRsp
        {
        
        };

        SetData(proto);
    }
}
