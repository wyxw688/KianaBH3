using KianaBH.GameServer.Server.Packet.Send.OpenWorld;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.OpenWorld;

[Opcode(CmdIds.GetOpenworldQuestActivityReq)]
public class HandlerGetOpenworldQuestActivityReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetOpenworldQuestActivityRsp());
    }
}
