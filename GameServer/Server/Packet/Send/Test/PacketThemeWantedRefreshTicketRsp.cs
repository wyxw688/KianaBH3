using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketThemeWantedRefreshTicketRsp : BasePacket
{
    public PacketThemeWantedRefreshTicketRsp() : base(CmdIds.ThemeWantedRefreshTicketRsp)
    {
        var proto = new ThemeWantedRefreshTicketRsp
        {
        
        };

        SetData(proto);
    }
}
