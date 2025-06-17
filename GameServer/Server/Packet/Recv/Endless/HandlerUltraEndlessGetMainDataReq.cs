using KianaBH.GameServer.Server.Packet.Send.Endless;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Endless;

[Opcode(CmdIds.UltraEndlessGetMainDataReq)]
public class HandlerUltraEndlessGetMainDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketUltraEndlessGetMainDataRsp(connection.Player!));
    }
}
