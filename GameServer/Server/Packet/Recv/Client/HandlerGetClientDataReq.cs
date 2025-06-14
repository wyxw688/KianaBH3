using KianaBH.GameServer.Server.Packet.Send.Client;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Client;

[Opcode(CmdIds.GetClientDataReq)]
public class HandlerGetClientDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetClientDataReq.Parser.ParseFrom(data);

        await connection.SendPacket(new PacketGetClientDataRsp(req.Id,req.Type, connection.Player!));
    }
}
