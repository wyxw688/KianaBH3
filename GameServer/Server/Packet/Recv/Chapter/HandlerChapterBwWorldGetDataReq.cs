using KianaBH.GameServer.Server.Packet.Send.Chapter;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Chapter;

[Opcode(CmdIds.ChapterBwWorldGetDataReq)]
public class HandlerChapterBwWorldGetDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = ChapterBwWorldGetDataReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketChapterBwWorldGetDataRsp(req.ChapterId));
    }
}
