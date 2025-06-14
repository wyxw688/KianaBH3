using KianaBH.GameServer.Server.Packet.Send.Chapter;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Chapter;

[Opcode(CmdIds.ChapterKnightRichManGetDataReq)]
public class HandlerChapterKnightRichManGetDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = ChapterKnightRichManGetDataReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketChapterKnightRichManGetDataRsp(req.RichManId));
    }
}
