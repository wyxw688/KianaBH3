using KianaBH.GameServer.Server.Packet.Send.Client;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Client;

[Opcode(CmdIds.GetClientSettingReq)]
public class HandlerGetClientSettingReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetClientSettingReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketGetClientSettingRsp(req.ClientSettingType));
    }
}
