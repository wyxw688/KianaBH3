using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Mission;

public class PacketGetMissionDataRsp : BasePacket
{
    public PacketGetMissionDataRsp(List<Proto.Mission> MissionList, bool IsAll) : base(CmdIds.GetMissionDataRsp)
    {
        var proto = new GetMissionDataRsp
        {
            ChallengeMission = new ChallengeMissionData { IsUnlock = true },
            CloseMissionList = { MissionList.Select(m => m.MissionId) },
            IsAll = IsAll,
            IsInActivity = true,
            MainlineStep = new MainlineStepMission { IsUpdate = true },
            MissionList = { MissionList }
        };

        SetData(proto);
    }
}
