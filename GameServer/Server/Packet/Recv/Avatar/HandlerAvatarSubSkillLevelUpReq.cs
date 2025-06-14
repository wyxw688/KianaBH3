using KianaBH.GameServer.Server.Packet.Send.Avatar;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Avatar;

[Opcode(CmdIds.AvatarSubSkillLevelUpReq)]
public class HandlerAvatarSubSkillLevelUpReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketAvatarSubSkillLevelUpRsp());
    }
}
