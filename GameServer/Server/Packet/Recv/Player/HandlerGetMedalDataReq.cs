using KianaBH.GameServer.Server.Packet.Send.Player;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Player;

[Opcode(CmdIds.GetMedalDataReq)]
public class HandlerGetMedalDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetMedalDataRsp());
    }
}
