using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Mission;

public class PacketGetMissionGroupMainInfoRsp : BasePacket
{
    public PacketGetMissionGroupMainInfoRsp() : base(CmdIds.GetMissionGroupMainInfoRsp)
    {
        // TODO: Hardcoded

        var proto = new GetMissionGroupMainInfoRsp
        {
            HasTakeRewardMissionGroupList = { 97001 }
        };

        SetData(proto);
    }
}
