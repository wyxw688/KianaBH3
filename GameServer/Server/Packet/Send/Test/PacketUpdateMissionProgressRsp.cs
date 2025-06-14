using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketUpdateMissionProgressRsp : BasePacket
{
    public PacketUpdateMissionProgressRsp() : base(CmdIds.UpdateMissionProgressRsp)
    {
        var proto = new UpdateMissionProgressRsp
        {
        
        };

        SetData(proto);
    }
}
