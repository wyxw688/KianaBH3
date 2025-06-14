using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Chapter;

public class PacketChapterBwWorldGetDataRsp : BasePacket
{
    public PacketChapterBwWorldGetDataRsp(uint ChapterId) : base(CmdIds.ChapterBwWorldGetDataRsp)
    {
        var proto = new ChapterBwWorldGetDataRsp
        {
            ChapterBwWorld = new ChapterBwWorld 
            {
                ChapterId = ChapterId
            }
        };

        SetData(proto);
    }
}
