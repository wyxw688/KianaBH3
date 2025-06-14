using Azure.Core;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Chapter;

public class PacketChapterKnightRichManGetDataRsp : BasePacket
{
    public PacketChapterKnightRichManGetDataRsp(uint RichManId) : base(CmdIds.ChapterKnightRichManGetDataRsp)
    {
        var proto = new ChapterKnightRichManGetDataRsp
        {
            RichManId = RichManId,
            Retcode = ChapterKnightRichManGetDataRsp.Types.Retcode.NotOpen, // set to NotOpen to prevent null reference error pop up
        };

        SetData(proto);
    }
}
