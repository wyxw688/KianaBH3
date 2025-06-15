using KianaBH.GameServer.Server.Packet.Send.Item;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Item;

[Opcode(CmdIds.RefineStigmataRuneReq)]
public class HandlerRefineStigmataRuneReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = RefineStigmataRuneReq.Parser.ParseFrom(data);
        var player = connection.Player!;

        await player.InventoryManager!.GenerateRune((int)req.UniqueId,req.Type,req.TimesType,(int)req.LockRuneIndex);
        await connection.SendPacket(new PacketRefineStigmataRuneRsp(player,(int)req.UniqueId, req.TimesType));
    }
}
