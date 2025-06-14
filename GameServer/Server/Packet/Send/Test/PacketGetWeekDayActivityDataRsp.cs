using KianaBH.KcpSharp;
using KianaBH.Proto;
using KianaBH.Util.Extensions;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketGetWeekDayActivityDataRsp : BasePacket
{
    public PacketGetWeekDayActivityDataRsp() : base(CmdIds.GetWeekDayActivityDataRsp)
    {
        // TODO: Hardcoded
        var now = (uint)Extensions.GetUnixSec();

        var proto = new GetWeekDayActivityDataRsp
        {
            ActivityList =
            {
                new WeekDayActivity
                {
                    ActivityId = 1003,
                    StageIdList = { 101302, 101303, 101304, 101305 },
                    EnterTimes = 1,
                    EndTime = now + 3600 * 24 * 7,
                    ActivityBeginTime = now * 10 / 8,
                }
            }
        };

        SetData(proto);
    }
}
