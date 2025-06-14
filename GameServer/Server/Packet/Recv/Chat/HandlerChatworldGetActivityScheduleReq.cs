using KianaBH.GameServer.Server.Packet.Send.Chat;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Chat;

[Opcode(CmdIds.ChatworldGetActivityScheduleReq)]
public class HandlerChatworldGetActivityScheduleReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketChatworldGetActivityScheduleRsp());
    }
}
