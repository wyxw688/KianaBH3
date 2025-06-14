using KianaBH.GameServer.Server.Packet.Send.Adventure;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Adventure;

[Opcode(CmdIds.GetAdventureGroupReq)]
public class HandlerGetAdventureGroupReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetAdventureGroupRsp());
    }
}
