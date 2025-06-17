using KianaBH.GameServer.Server.Packet.Send.Player;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Warship;

[Opcode(CmdIds.SetWarshipReq)]
public class HandlerSetWarshipReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = SetWarshipReq.Parser.ParseFrom(data);

        connection.Player!.Data!.WarshipId = (int)req.WarshipId;
        await connection.SendPacket(new PacketGetMainDataRsp(req.WarshipId));
        await connection.SendPacket(CmdIds.SetWarshipRsp);
    }
}
