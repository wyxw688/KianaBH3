using KianaBH.GameServer.Server.Packet.Send.Dorm;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Dorm;

[Opcode(CmdIds.GetDormDataReq)]
public class HandlerGetDormDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetDormDataRsp());
    }
}
