using KianaBH.GameServer.Server.Packet.Send.DLC;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.DLC;

[Opcode(CmdIds.GetDLCAvatarReq)]
public class HandlerGetDLCAvatarReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetDLCAvatarRsp());
    }
}
