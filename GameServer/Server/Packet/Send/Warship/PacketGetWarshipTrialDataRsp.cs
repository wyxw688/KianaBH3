using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Warship;

public class PacketGetWarshipTrialDataRsp : BasePacket
{
    public PacketGetWarshipTrialDataRsp() : base(CmdIds.GetWarshipTrialDataRsp)
    {
        var proto = new GetWarshipTrialDataRsp
        {
            IsAll = true,
        };

        SetData(proto);
    }
}
