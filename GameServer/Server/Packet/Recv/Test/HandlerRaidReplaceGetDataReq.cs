using KianaBH.GameServer.Server.Packet.Send.Test;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Test;

[Opcode(CmdIds.RaidReplaceGetDataReq)]
public class HandlerRaidReplaceGetDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketRaidReplaceGetDataRsp());
    }
}
