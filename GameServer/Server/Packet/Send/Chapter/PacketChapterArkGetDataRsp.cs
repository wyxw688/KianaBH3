using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Chapter;

public class PacketChapterArkGetDataRsp : BasePacket
{
    public PacketChapterArkGetDataRsp(uint ChapterId) : base(CmdIds.ChapterArkGetDataRsp)
    {
        // TODO: Hardcoded

        var avatarList = new List<uint> { 1, 2, 3, 4, 5 };

        var proto = new ChapterArkGetDataRsp
        {
            ChapterArk = new ChapterArk
            {
                ChapterId = ChapterId,
                AvatarList = { avatarList },
                IsFinishOpening = true,
                RoleList =
                {
                    avatarList.Select(id => new ChapterArkRoleInfo
                    {
                        Id = id,
                        Level = 30
                    })
                },
                SkillList =
                {
                    Enumerable.Range(1, 5)
                    .SelectMany(i => Enumerable.Range(1, 12)
                    .Select(j => new ChapterArkSkillInfo
                    {
                        Id = (uint)(i * 100 + j),
                        Level = (uint)(j > 3 ? 3 : 1)
                    }))
                }
            }
        };

        SetData(proto);
    }
}
