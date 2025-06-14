using KianaBH.GameServer.Server.Packet.Send.Challenge;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Challenge;

[Opcode(CmdIds.GetChallengeStepCompensationInfoReq)]
public class HandlerGetChallengeStepCompensationInfoReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetChallengeStepCompensationInfoRsp());
    }
}
