using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Avatar;

[Opcode(CmdIds.SetDressReq)]
public class HandlerSetDressReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = SetDressReq.Parser.ParseFrom(data);
        var player = connection.Player!;
        var valk = player.AvatarManager!.GetAvatar((int)req.AvatarId);
        if (valk == null) return;
        valk.DressId = (int)req.DressId;
        await connection.SendPacket(CmdIds.SetDressRsp);
    }
}
