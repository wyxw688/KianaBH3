using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketGetWikiDataRsp : BasePacket
{
    public PacketGetWikiDataRsp() : base(CmdIds.GetWikiDataRsp)
    {
        var proto = new GetWikiDataRsp
        {
            HasTakeActivitySuitRewardList = { 132 },
            HasTakeRatingRewardList = { 1, 2, 3, 4, 5, 6 }
        };

        SetData(proto);
    }
}
