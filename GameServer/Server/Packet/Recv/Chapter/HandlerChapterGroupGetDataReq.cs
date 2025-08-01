using KianaBH.GameServer.Server.Packet.Send.Chapter;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Chapter;

[Opcode(CmdIds.ChapterGroupGetDataReq)]
public class HandlerChapterGroupGetDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketChapterGroupGetDataRsp());
    }
}
