using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Avatar;

public class PacketGetAvatarRollDataRsp : BasePacket
{
    public PacketGetAvatarRollDataRsp(PlayerInstance player) : base(CmdIds.GetAvatarRollDataRsp)
    {
        //var proto = new GetAvatarRollDataRsp
        //{
        //    IsAll = true,
        //    RollList =
        //    {
        //        player.AvatarManager?.AvatarData?.Avatars?
        //        .Select(avatar => new AvatarRoll
        //        {
        //            AvatarId = avatar.AvatarId,
        //            IsUnlock = true
        //        })
        //    }
        //};

        var proto = new GetAvatarRollDataRsp
        {
            IsAll = true,
            RollList =
            {
                new AvatarRoll { AvatarId = 101, IsUnlock = true },
                new AvatarRoll { AvatarId = 102, IsUnlock = true },
                new AvatarRoll { AvatarId = 103, IsUnlock = true },
                new AvatarRoll { AvatarId = 104, IsUnlock = true },
                new AvatarRoll { AvatarId = 105, IsUnlock = true },
                new AvatarRoll { AvatarId = 106, IsUnlock = true },
                new AvatarRoll { AvatarId = 111, IsUnlock = true },
                new AvatarRoll { AvatarId = 112, IsUnlock = true },
                new AvatarRoll { AvatarId = 113, IsUnlock = true },
                new AvatarRoll { AvatarId = 114, IsUnlock = true },
                new AvatarRoll { AvatarId = 201, IsUnlock = true },
                new AvatarRoll { AvatarId = 202, IsUnlock = true },
                new AvatarRoll { AvatarId = 203, IsUnlock = true },
                new AvatarRoll { AvatarId = 204, IsUnlock = true },
                new AvatarRoll { AvatarId = 205, IsUnlock = true },
                new AvatarRoll { AvatarId = 206, IsUnlock = true },
                new AvatarRoll { AvatarId = 211, IsUnlock = true },
                new AvatarRoll { AvatarId = 212, IsUnlock = true },
                new AvatarRoll { AvatarId = 213, IsUnlock = true },
                new AvatarRoll { AvatarId = 214, IsUnlock = true },
                new AvatarRoll { AvatarId = 301, IsUnlock = true },
                new AvatarRoll { AvatarId = 302, IsUnlock = true },
                new AvatarRoll { AvatarId = 303, IsUnlock = true },
                new AvatarRoll { AvatarId = 311, IsUnlock = true },
                new AvatarRoll { AvatarId = 312, IsUnlock = true },
                new AvatarRoll { AvatarId = 313, IsUnlock = true },
                new AvatarRoll { AvatarId = 314, IsUnlock = true },
                new AvatarRoll { AvatarId = 317, IsUnlock = true },
                new AvatarRoll { AvatarId = 401, IsUnlock = true },
                new AvatarRoll { AvatarId = 402, IsUnlock = true },
                new AvatarRoll { AvatarId = 403, IsUnlock = true },
                new AvatarRoll { AvatarId = 404, IsUnlock = true },
                new AvatarRoll { AvatarId = 411, IsUnlock = true },
                new AvatarRoll { AvatarId = 412, IsUnlock = true },
                new AvatarRoll { AvatarId = 421, IsUnlock = true },
                new AvatarRoll { AvatarId = 422, IsUnlock = true },
                new AvatarRoll { AvatarId = 501, IsUnlock = true },
                new AvatarRoll { AvatarId = 502, IsUnlock = true },
                new AvatarRoll { AvatarId = 503, IsUnlock = true },
                new AvatarRoll { AvatarId = 504, IsUnlock = true },
                new AvatarRoll { AvatarId = 506, IsUnlock = true },
                new AvatarRoll { AvatarId = 507, IsUnlock = true },
                new AvatarRoll { AvatarId = 511, IsUnlock = true },
                new AvatarRoll { AvatarId = 601, IsUnlock = true },
                new AvatarRoll { AvatarId = 602, IsUnlock = true },
                new AvatarRoll { AvatarId = 603, IsUnlock = true },
                new AvatarRoll { AvatarId = 604, IsUnlock = true },
                new AvatarRoll { AvatarId = 611, IsUnlock = true },
                new AvatarRoll { AvatarId = 612, IsUnlock = true },
                new AvatarRoll { AvatarId = 702, IsUnlock = true },
                new AvatarRoll { AvatarId = 703, IsUnlock = true },
                new AvatarRoll { AvatarId = 705, IsUnlock = true },
                new AvatarRoll { AvatarId = 706, IsUnlock = true },
                new AvatarRoll { AvatarId = 711, IsUnlock = true },
                new AvatarRoll { AvatarId = 712, IsUnlock = true },
                new AvatarRoll { AvatarId = 713, IsUnlock = true },
                new AvatarRoll { AvatarId = 714, IsUnlock = true },
                new AvatarRoll { AvatarId = 801, IsUnlock = true },
                new AvatarRoll { AvatarId = 802, IsUnlock = true },
                new AvatarRoll { AvatarId = 803, IsUnlock = true },
                new AvatarRoll { AvatarId = 2201, IsUnlock = true },
                new AvatarRoll { AvatarId = 2202, IsUnlock = true },
                new AvatarRoll { AvatarId = 2401, IsUnlock = true },
                new AvatarRoll { AvatarId = 2501, IsUnlock = true },
                new AvatarRoll { AvatarId = 2601, IsUnlock = true },
                new AvatarRoll { AvatarId = 2801, IsUnlock = true },
                new AvatarRoll { AvatarId = 2901, IsUnlock = true },
                new AvatarRoll { AvatarId = 2902, IsUnlock = true },
                new AvatarRoll { AvatarId = 3101, IsUnlock = true },
                new AvatarRoll { AvatarId = 3201, IsUnlock = true },
                new AvatarRoll { AvatarId = 3301, IsUnlock = true },
                new AvatarRoll { AvatarId = 3501, IsUnlock = true },
                new AvatarRoll { AvatarId = 3601, IsUnlock = true },
                new AvatarRoll { AvatarId = 3701, IsUnlock = true },
                new AvatarRoll { AvatarId = 20201, IsUnlock = true },
                new AvatarRoll { AvatarId = 20301, IsUnlock = true },
                new AvatarRoll { AvatarId = 20401, IsUnlock = true },
                new AvatarRoll { AvatarId = 70005, Progress = 18 },
                new AvatarRoll { AvatarId = 70006, Progress = 18 },
                new AvatarRoll { AvatarId = 70010, Progress = 18 },
                new AvatarRoll
                {
                    AvatarId = 70011,
                    HasTakeGroupList = { 111 },
                    Progress = 33
                },
                new AvatarRoll
                {
                    AvatarId = 70019,
                    HasTakeGroupList = { 191, 192 },
                    Progress = 87
                },
                new AvatarRoll
                {
                    AvatarId = 70022,
                    HasTakeGroupList = { 221, 222 },
                    IsUnlock = true,
                    Progress = 68
                },
                new AvatarRoll
                {
                    AvatarId = 70025,
                    HasTakeGroupList = { 251, 252 },
                    Progress = 87
                },
                new AvatarRoll
                {
                    AvatarId = 70030,
                    HasTakeGroupList = { 301, 302 },
                    Progress = 87
                },
                new AvatarRoll
                {
                    AvatarId = 70032,
                    HasTakeGroupList = { 321 },
                    Progress = 33
                },
                new AvatarRoll { AvatarId = 70038, Progress = 21 },
                new AvatarRoll { AvatarId = 70065, Progress = 33 },
                new AvatarRoll
                {
                    AvatarId = 70080,
                    HasTakeGroupList = { 801, 802 },
                    IsUnlock = true,
                    Progress = 63
                }
            }
        };

        SetData(proto);
    }
}
