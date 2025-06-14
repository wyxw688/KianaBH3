using KianaBH.GameServer.Server.Packet.Send.Player;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Player;

[Opcode(CmdIds.GetMainDataReq)]
public class HandlerGetMainDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetMainDataRsp(connection.Player!));
    }
}
