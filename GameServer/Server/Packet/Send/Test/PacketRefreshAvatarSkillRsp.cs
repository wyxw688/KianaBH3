using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketRefreshAvatarSkillRsp : BasePacket
{
    public PacketRefreshAvatarSkillRsp() : base(CmdIds.RefreshAvatarSkillRsp)
    {
        var proto = new RefreshAvatarSkillRsp
        {
        
        };

        SetData(proto);
    }
}
