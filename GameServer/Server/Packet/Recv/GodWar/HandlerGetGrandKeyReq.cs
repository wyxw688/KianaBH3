using KianaBH.GameServer.Server.Packet.Send.GodWar;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.GodWar;

[Opcode(CmdIds.GetGrandKeyReq)]
public class HandlerGetGrandKeyReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetGrandKeyRsp());
    }
}
