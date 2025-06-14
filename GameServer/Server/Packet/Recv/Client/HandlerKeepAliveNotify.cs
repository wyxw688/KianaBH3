using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Client;

[Opcode(CmdIds.KeepAliveNotify)]
public class HandlerKeepAliveNotify : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.Player!.OnHeartBeat();
        await connection.SendPacket(CmdIds.KeepAliveNotify);
    }
}
