using KianaBH.GameServer.Server.Packet.Send.Story;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Story;

[Opcode(CmdIds.GetExtraStoryDataReq)]
public class HandlerGetExtraStoryDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetExtraStoryDataRsp());
    }
}
