using KianaBH.GameServer.Server.Packet.Send.Mission;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Mission;

[Opcode(CmdIds.GetMissionThemeDataReq)]
public class HandlerGetMissionThemeDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetMissionThemeDataRsp());
    }
}
