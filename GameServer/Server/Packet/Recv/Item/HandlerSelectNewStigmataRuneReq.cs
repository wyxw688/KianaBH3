using KianaBH.GameServer.Server.Packet.Send.Item;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Item;

[Opcode(CmdIds.SelectNewStigmataRuneReq)]
public class HandlerSelectNewStigmataRuneReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = SelectNewStigmataRuneReq.Parser.ParseFrom(data);
        var player = connection.Player!;

        if (req.IsSelect && req.SelectUniqueId > 0)
        {
            await player.InventoryManager!.SelectRune((int)req.UniqueId, (int)req.SelectUniqueId);
        }

        await connection.SendPacket(new PacketSelectNewStigmataRuneRsp(req.SelectUniqueId,req.IsSelect));
    }
}
