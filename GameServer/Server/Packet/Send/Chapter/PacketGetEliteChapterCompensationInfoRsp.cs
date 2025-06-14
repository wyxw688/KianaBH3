using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Chapter;

public class PacketGetEliteChapterCompensationInfoRsp : BasePacket
{
    public PacketGetEliteChapterCompensationInfoRsp() : base(CmdIds.GetEliteChapterCompensationInfoRsp)
    {
        // TODO: Hardcoded
        var proto = new GetEliteChapterCompensationInfoRsp
        {
            ChapterList =
            {
                Enumerable.Range(1, 35).Select(i => new EliteChapterCompensationInfo
                {
                    ChapterId = (uint)i,
                    HasTakenCompensation = true
                })
            }
        };

        SetData(proto);
    }
}
