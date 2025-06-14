using KianaBH.GameServer.Server.Packet.Send.Adventure;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Adventure;

[Opcode(CmdIds.GetAdventureStorySweepInfoReq)]
public class HandlerGetAdventureStorySweepInfoReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetAdventureStorySweepInfoRsp());
    }
}
