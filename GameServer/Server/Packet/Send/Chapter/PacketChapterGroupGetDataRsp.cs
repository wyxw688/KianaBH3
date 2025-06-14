using KianaBH.KcpSharp;
using KianaBH.Proto;
using KianaBH.Data;

namespace KianaBH.GameServer.Server.Packet.Send.Chapter;

public class PacketChapterGroupGetDataRsp : BasePacket
{
    public PacketChapterGroupGetDataRsp() : base(CmdIds.ChapterGroupGetDataRsp)
    {
        var proto = new ChapterGroupGetDataRsp
        {
            IsAll = true,
            ChapterGroupList =
            {
                GameData.ChapterGroupConfigData.Select(x => new ChapterGroup
                {
                    Id = (uint)x.Key,
                    SiteList =
                    {
                        x.Value.SiteList.Select(siteId => new ChapterGroupSite
                        {
                            ChapterId = (uint)siteId,
                            SiteId = (uint)siteId,
                            Status = ChapterGroupSiteStatus.Finished,
                        })
                    }

                })
            }
        };

        SetData(proto);
    }
}
