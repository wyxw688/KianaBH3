using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Avatar;

public class PacketAvatarSubSkillLevelUpRsp : BasePacket
{
    public PacketAvatarSubSkillLevelUpRsp() : base(CmdIds.AvatarSubSkillLevelUpRsp)
    {
        // TODO: Implement
        var proto = new AvatarSubSkillLevelUpRsp
        {
        
        };

        SetData(proto);
    }
}
