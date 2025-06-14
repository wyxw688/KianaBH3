using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetScratchTicketRsp : BasePacket
{
    public PacketGetScratchTicketRsp() : base(CmdIds.GetScratchTicketRsp)
    {
        var proto = new GetScratchTicketRsp
        {
            Retcode = GetScratchTicketRsp.Types.Retcode.ActivityNotOpen,
        };

        SetData(proto);
    }
}
