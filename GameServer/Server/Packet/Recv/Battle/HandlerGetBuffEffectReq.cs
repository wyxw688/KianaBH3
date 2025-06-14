using KianaBH.GameServer.Server.Packet.Send.Battle;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Battle;

[Opcode(CmdIds.GetBuffEffectReq)]
public class HandlerGetBuffEffectReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetBuffEffectReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketGetBuffEffectRsp(req.EffectIdList));
    }
}
