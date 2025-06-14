using KianaBH.GameServer.Server.Packet.Send.Armada;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Armada;

[Opcode(CmdIds.GetArmadaStageScoreActivityReq)]
public class HandlerGetArmadaStageScoreActivityReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetArmadaStageScoreActivityRsp());
    }
}
