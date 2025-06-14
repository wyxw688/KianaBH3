using KianaBH.GameServer.Server.Packet.Send.Test;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Test;

[Opcode(CmdIds.RefineStigmataRuneReq)]
public class HandlerRefineStigmataRuneReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketRefineStigmataRuneRsp());
    }
}
