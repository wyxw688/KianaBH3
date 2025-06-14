using System.Security.Cryptography;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetVirtualAvatarGroupDetailRsp : BasePacket
{
    public PacketGetVirtualAvatarGroupDetailRsp(uint GroupId) : base(CmdIds.GetVirtualAvatarGroupDetailRsp)
    {
        var proto = new GetVirtualAvatarGroupDetailRsp();

        if (GroupId == 114)
        {
            proto.VirtualAvatarGroup = new VirtualAvatarGroup
            {
                GroupId = 114,
                VirtualAvatarList =
                {
                    new VirtualAvatar { VirtualAvatarId = 300001 },
                    new VirtualAvatar { VirtualAvatarId = 300003 }
                },
                VirtualAvatarTeamList = { 300001, 300003 }
            };
        }
        else if (GroupId == 111)
        {
            proto.VirtualAvatarGroup = new VirtualAvatarGroup
            {
                GroupId = 111,
                VirtualAvatarList =
                {
                    new VirtualAvatar { VirtualAvatarId = 300001 }
                },
                VirtualAvatarTeamList = { 300001 }
            };
        }

        SetData(proto);
    }
}
