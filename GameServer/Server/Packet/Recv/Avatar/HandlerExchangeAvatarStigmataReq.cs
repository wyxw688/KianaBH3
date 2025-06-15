using KianaBH.GameServer.Server.Packet.Send.Avatar;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Avatar;

[Opcode(CmdIds.ExchangeAvatarStigmataReq)]
public class HandlerExchangeAvatarStigmataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = ExchangeAvatarStigmataReq.Parser.ParseFrom(data);
        var player = connection.Player!;

        await player.InventoryManager!.ExchangeStigmata((int)req.AvatarId1, (int)req.AvatarId2, ((int)req.Slot-1));

        await connection.SendPacket(new PacketExchangeAvatarStigmataRsp(req.AvatarId1,req.AvatarId2,req.Slot));
    }
}
