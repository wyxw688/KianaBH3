using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.GodWar;

public class PacketRefreshGodWarTicketRsp : BasePacket
{
    public PacketRefreshGodWarTicketRsp(uint GodWarId) : base(CmdIds.RefreshGodWarTicketRsp)
    {
        var proto = new RefreshGodWarTicketRsp
        {
            GodWarId = GodWarId
        };

        SetData(proto);
    }
}
