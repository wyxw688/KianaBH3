using KianaBH.GameServer.Server.Packet.Send.BattlePass;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.BattlePass;

[Opcode(CmdIds.GetBattlePassMissionPanelReq)]
public class HandlerGetBattlePassMissionPanelReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetBattlePassMissionPanelRsp());
    }
}
