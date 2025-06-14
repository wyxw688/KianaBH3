using KianaBH.GameServer.Server.Packet.Send.Guide;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Guide;

[Opcode(CmdIds.GetFinishGuideDataReq)]
public class HandlerGetFinishGuideDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetFinishGuideDataRsp(connection.Player!));
    }
}
