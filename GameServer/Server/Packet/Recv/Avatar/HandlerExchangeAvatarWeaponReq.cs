using KianaBH.GameServer.Server.Packet.Send.Avatar;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Avatar;

[Opcode(CmdIds.ExchangeAvatarWeaponReq)]
public class HandlerExchangeAvatarWeaponReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = ExchangeAvatarWeaponReq.Parser.ParseFrom(data);
        var player = connection.Player!;

        await player.InventoryManager!.ExchangeAvatar((int)req.AvatarId1, (int)req.AvatarId2);

        await connection.SendPacket(CmdIds.ExchangeAvatarWeaponRsp);
    }
}
