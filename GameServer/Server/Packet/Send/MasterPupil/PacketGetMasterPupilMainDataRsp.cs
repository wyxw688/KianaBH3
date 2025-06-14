using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.MasterPupil;

public class PacketGetMasterPupilMainDataRsp : BasePacket
{
    public PacketGetMasterPupilMainDataRsp() : base(CmdIds.GetMasterPupilMainDataRsp)
    {
        var proto = new GetMasterPupilMainDataRsp
        {
        
        };

        SetData(proto);
    }
}
