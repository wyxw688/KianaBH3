using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.MasterPupil;

public class PacketGetMasterPupilCardRsp : BasePacket
{
    public PacketGetMasterPupilCardRsp() : base(CmdIds.GetMasterPupilCardRsp)
    {
        var proto = new GetMasterPupilCardRsp
        {
        
        };

        SetData(proto);
    }
}
