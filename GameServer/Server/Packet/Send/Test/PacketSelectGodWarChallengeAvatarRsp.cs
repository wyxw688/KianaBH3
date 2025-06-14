using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketSelectGodWarChallengeAvatarRsp : BasePacket
{
    public PacketSelectGodWarChallengeAvatarRsp() : base(CmdIds.SelectGodWarChallengeAvatarRsp)
    {
        var proto = new SelectGodWarChallengeAvatarRsp
        {
        
        };

        SetData(proto);
    }
}
