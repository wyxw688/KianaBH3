using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetRewardLineActivityRsp : BasePacket
{
    public PacketGetRewardLineActivityRsp() : base(CmdIds.GetRewardLineActivityRsp)
    {
        // TODO: Hardcoded

        var proto = new GetRewardLineActivityRsp
        {
            RewardLineActivityList =
            {
                Enumerable.Range(10, 4) // 10–13
                    .Concat([14, 15, 16, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39])
                    .Concat(Enumerable.Range(45, 18)) // 45–62
                    .Concat([64, 65, 66, 67, 68, 69, 70, 71, 72])
                    .Select(id => new RewardLineActivity { Id = (uint)id })
                    .ToList()
            }
        };

        SetData(proto);
    }
}
