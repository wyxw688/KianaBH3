using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Avatar;

public class PacketGetAvatarMissionActivityRsp : BasePacket
{
    public PacketGetAvatarMissionActivityRsp() : base(CmdIds.GetAvatarMissionActivityRsp)
    {
        var proto = new GetAvatarMissionActivityRsp
        {
        
        };

        SetData(proto);
    }
}
