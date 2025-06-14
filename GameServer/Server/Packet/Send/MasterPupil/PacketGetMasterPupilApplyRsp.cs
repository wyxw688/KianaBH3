using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.MasterPupil;

public class PacketGetMasterPupilApplyRsp : BasePacket
{
    public PacketGetMasterPupilApplyRsp() : base(CmdIds.GetMasterPupilApplyRsp)
    {
        // TODO: Hardcoded
        var proto = new GetMasterPupilApplyRsp
        {
            Type = MasterPupilType.MasterPupilMasterType
        };

        SetData(proto);
    }
}
