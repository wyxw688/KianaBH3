using KianaBH.GameServer.Server.Packet.Send.Elf;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Elf;

[Opcode(CmdIds.GetElfDataReq)]
public class HandlerGetElfDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetElfDataRsp(connection.Player!));
    }
}
