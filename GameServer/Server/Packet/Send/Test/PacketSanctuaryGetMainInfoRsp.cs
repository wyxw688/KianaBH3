using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketSanctuaryGetMainInfoRsp : BasePacket
{
    public PacketSanctuaryGetMainInfoRsp() : base(CmdIds.SanctuaryGetMainInfoRsp)
    {
        var proto = new SanctuaryGetMainInfoRsp
        {
            Retcode = SanctuaryGetMainInfoRsp.Types.Retcode.NotOpen, // set to NotOpen to prevent null reference error pop up
        };

        SetData(proto);
    }
}
