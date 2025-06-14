using KianaBH.GameServer.Server.Packet.Send.OpenWorld;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.OpenWorld;

[Opcode(CmdIds.GetOpenworldEndlessDataReq)]
public class HandlerGetOpenworldEndlessDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetOpenworldEndlessDataReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketGetOpenworldEndlessDataRsp(req.Level,req.Type));
    }
}
