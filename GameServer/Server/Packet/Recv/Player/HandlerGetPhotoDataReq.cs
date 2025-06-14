using KianaBH.GameServer.Server.Packet.Send.Player;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Player;

[Opcode(CmdIds.GetPhotoDataReq)]
public class HandlerGetPhotoDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetPhotoDataReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketGetPhotoDataRsp(req.Type));
    }
}
