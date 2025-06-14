using KianaBH.GameServer.Server.Packet.Send.Player;
using KianaBH.GameServer.Server.Packet.Send.Warship;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Warship;

[Opcode(CmdIds.SetWarshipAvatarReq)]
public class HandlerSetWarshipAvatarReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var player = connection.Player!;
        var req = SetWarshipAvatarReq.Parser.ParseFrom(data);

        player.Data.WarshipAvatar.FirstAvatarId = (int)req.FirstAvatarId;
        player.Data.WarshipAvatar.SecondAvatarId = (int)req.SecondAvatarId;

        await connection.SendPacket(new PacketGetMainDataRsp(req.FirstAvatarId,req.SecondAvatarId));
        await connection.SendPacket(CmdIds.SetWarshipAvatarRsp);
    }
}
