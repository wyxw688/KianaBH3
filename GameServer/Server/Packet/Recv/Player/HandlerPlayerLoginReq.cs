using KianaBH.GameServer.Server.Packet.Send.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Player;

[Opcode(CmdIds.PlayerLoginReq)]
public class HandlerPlayerLoginReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        connection.State = SessionStateEnum.ACTIVE;
        await connection.Player!.OnLogin();
        await connection.SendPacket(new PacketPlayerLoginRsp(connection.Player!));
    }
}
