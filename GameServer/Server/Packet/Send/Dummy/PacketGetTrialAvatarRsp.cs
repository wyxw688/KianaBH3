using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetTrialAvatarRsp : BasePacket
{
    public PacketGetTrialAvatarRsp() : base(CmdIds.GetTrialAvatarRsp)
    {
        var proto = new GetTrialAvatarRsp
        {
            IsAllUpdate = true,
        };

        SetData(proto);
    }
}
