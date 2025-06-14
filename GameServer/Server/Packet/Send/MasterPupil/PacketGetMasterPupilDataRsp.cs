using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.MasterPupil;

public class PacketGetMasterPupilDataRsp : BasePacket
{
    public PacketGetMasterPupilDataRsp() : base(CmdIds.GetMasterPupilDataRsp)
    {
        var proto = new GetMasterPupilDataRsp
        {
        
        };

        SetData(proto);
    }
}
