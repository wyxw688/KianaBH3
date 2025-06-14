using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetVipRewardDataRsp : BasePacket
{
    public PacketGetVipRewardDataRsp() : base(CmdIds.GetVipRewardDataRsp)
    {
        // TODO: Hardcoded
        var proto = new GetVipRewardDataRsp
        {
            TotalPayHcoin = 17185,
            VipRewardList =
            {
                new VipReward
                {
                    IsSpecialShineList = { 1 },
                    PayHcoin = 10,
                    RewardBatch = 1,
                    RewardIdList = { 2101, 2201 },
                    SpecialRewardIdList = { 2101 },
                    TakenRewardIdList = { 2101, 2201, 2251 },
                    VipLevel = 1
                },
                new VipReward
                {
                    IsSpecialShineList = { 1, 1 },
                    PayHcoin = 300,
                    RewardBatch = 1,
                    RewardIdList = { 2002, 2102, 2302 },
                    SpecialRewardIdList = { 2102, 2302 },
                    TakenRewardIdList = { 2002, 2102, 2252, 2302 },
                    VipLevel = 2
                },
                new VipReward
                {
                    IsSpecialShineList = { 1, 1 },
                    PayHcoin = 500,
                    RewardBatch = 1,
                    RewardIdList = { 2103, 2203, 2303 },
                    SpecialRewardIdList = { 2103, 2303 },
                    TakenRewardIdList = { 2103, 2203, 2253, 2303 },
                    VipLevel = 3
                },
                new VipReward
                {
                    IsSpecialShineList = { 1, 1 },
                    PayHcoin = 1000,
                    RewardBatch = 1,
                    RewardIdList = { 2004, 2104, 2304 },
                    SpecialRewardIdList = { 2104, 2304 },
                    TakenRewardIdList = { 2004, 2104, 2254, 2304 },
                    VipLevel = 4
                },
                new VipReward
                {
                    IsSpecialShineList = { 1, 1 },
                    PayHcoin = 2000,
                    RewardBatch = 1,
                    RewardIdList = { 2105, 2205, 2305 },
                    SpecialRewardIdList = { 2105, 2305 },
                    TakenRewardIdList = { 2105, 2205, 2255, 2305 },
                    VipLevel = 5
                },
                new VipReward
                {
                    IsSpecialShineList = { 1, 1 },
                    PayHcoin = 5000,
                    RewardBatch = 1,
                    RewardIdList = { 2006, 2106, 2306 },
                    SpecialRewardIdList = { 2106, 2306 },
                    TakenRewardIdList = { 2006, 2106, 2256, 2306 },
                    VipLevel = 6
                },
                new VipReward
                {
                    IsSpecialShineList = { 1, 1 },
                    PayHcoin = 10000,
                    RewardBatch = 1,
                    RewardIdList = { 2107, 2207, 2257, 2307 },
                    SpecialRewardIdList = { 2107, 2307 },
                    TakenRewardIdList = { 2107, 2207, 2257, 2307 },
                    VipLevel = 7
                },
                new VipReward
                {
                    IsSpecialShineList = { 1, 1 },
                    PayHcoin = 20000,
                    RewardBatch = 1,
                    RewardIdList = { 2108, 2208, 2258, 2308 },
                    SpecialRewardIdList = { 2108, 2308 },
                    VipLevel = 8
                },
                new VipReward
                {
                    IsSpecialShineList = { 1, 1 },
                    PayHcoin = 50000,
                    RewardBatch = 1,
                    RewardIdList = { 2109, 2209, 2309 },
                    SpecialRewardIdList = { 2109, 2309 },
                    VipLevel = 9
                },
                new VipReward
                {
                    IsSpecialShineList = { 1, 1, 1 },
                    PayHcoin = 100000,
                    RewardBatch = 1,
                    RewardIdList = { 2110, 2210, 2310 },
                    SpecialRewardIdList = { 2110, 2310 },
                    VipLevel = 10
                },
                new VipReward
                {
                    IsSpecialShineList = { 1, 1, 1 },
                    PayHcoin = 150000,
                    RewardBatch = 1,
                    RewardIdList = { 2261, 2311 },
                    SpecialRewardIdList = { 2311 },
                    VipLevel = 11
                },
                new VipReward
                {
                    IsSpecialShineList = { 1, 1, 1 },
                    PayHcoin = 200000,
                    RewardBatch = 1,
                    RewardIdList = { 2262, 2312 },
                    SpecialRewardIdList = { 2312 },
                    VipLevel = 12
                },
                new VipReward
                {
                    IsSpecialShineList = { 1 },
                    PayHcoin = 250000,
                    RewardBatch = 1,
                    RewardIdList = { 2263, 2313 },
                    SpecialRewardIdList = { 2313 },
                    VipLevel = 13
                }
            }
        };

        SetData(proto);
    }
}
