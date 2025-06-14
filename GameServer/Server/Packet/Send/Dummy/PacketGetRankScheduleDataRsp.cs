using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetRankScheduleDataRsp : BasePacket
{
    public PacketGetRankScheduleDataRsp() : base(CmdIds.GetRankScheduleDataRsp)
    {
        var proto = new GetRankScheduleDataRsp
        {
        
        };

        SetData(proto);
    }
}
