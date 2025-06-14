using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketGetRegionUidRangeRsp : BasePacket
{
    public PacketGetRegionUidRangeRsp() : base(CmdIds.GetRegionUidRangeRsp)
    {
        var proto = new GetRegionUidRangeRsp
        {
            LocalRegionName = "overseas01",
            RegionUidRangeList =
            {
                new RegionUidRange
                {
                    StartUid = 1000,
                    EndUid = 50000000,
                    RegionName = "overseas01"
                }
            }
        };

        SetData(proto);
    }
}
