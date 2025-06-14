using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetActivityRewardStatisticDataRsp : BasePacket
{
    public PacketGetActivityRewardStatisticDataRsp() : base(CmdIds.GetActivityRewardStatisticDataRsp)
    {
        // TODO: Hardcoded

        var proto = new GetActivityRewardStatisticDataRsp
        {
            ActivityRewardData = new ActivityRewardStatisticData
            {
                Id = 118,
                ItemDataList =
                {
                    Enumerable.Range(506, 3).Select(i => new ActivityRewardStatisticItemData
                    {
                        ShowId = (uint)i
                    })
                }
            }
        };

        SetData(proto);
    }
}
