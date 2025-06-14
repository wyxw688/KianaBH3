using KianaBH.GameServer.Server.Packet.Send.Client;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Client;

[Opcode(CmdIds.GetClientMailDataReq)]
public class HandlerGetClientMailDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetClientMailDataRsp());
    }
}
