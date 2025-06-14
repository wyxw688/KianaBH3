using KianaBH.GameServer.Server.Packet.Send.Warship;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Warship;

[Opcode(CmdIds.GetWarshipTrialDataReq)]
public class HandlerGetWarshipTrialDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetWarshipTrialDataRsp());
    }
}
