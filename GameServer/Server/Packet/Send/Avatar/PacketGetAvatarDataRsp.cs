using Google.Protobuf.Collections;
using KianaBH.Database.Avatar;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Avatar;

public class PacketGetAvatarDataRsp : BasePacket
{
    public PacketGetAvatarDataRsp(List<AvatarInfo> Avatars, bool IsAll) : base(CmdIds.GetAvatarDataRsp)
    {
        var proto = new GetAvatarDataRsp
        {
            AvatarList = { Avatars.Select(avatar => avatar.ToProto()) },
            IsAll = IsAll
        };
        SetData(proto);
    }
}
