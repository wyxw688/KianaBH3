using KianaBH.Database.Avatar;
using KianaBH.GameServer.Game.Player;
using KianaBH.GameServer.Server.Packet.Send.Avatar;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Avatar;

[Opcode(CmdIds.GetAvatarDataReq)]
public class HandlerGetAvatarDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetAvatarDataReq.Parser.ParseFrom(data);
        var player = connection.Player!;
        var avatars = req.AvatarIdList.Any(id => id != 0)
            ? req.AvatarIdList
                .Select(id => player.AvatarManager!.GetAvatar(id))
                .Where(avatar => avatar != null)
                .ToList()!
            : player.AvatarManager?.AvatarData?.Avatars?.ToList();

        bool isAll = !req.AvatarIdList.Any(id => id != 0);
        await connection.SendPacket(new PacketGetAvatarDataRsp(avatars!, isAll));
    }
}
