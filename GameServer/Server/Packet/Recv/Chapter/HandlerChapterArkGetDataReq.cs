using KianaBH.GameServer.Server.Packet.Send.Chapter;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Chapter;

[Opcode(CmdIds.ChapterArkGetDataReq)]
public class HandlerChapterArkGetDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = ChapterArkGetDataReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketChapterArkGetDataRsp(req.ChapterId));
    }
}
