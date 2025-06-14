using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetDropLimitActivityRsp : BasePacket
{
    public PacketGetDropLimitActivityRsp() : base(CmdIds.GetDropLimitActivityRsp)
    {
        // TODO: Hardcoded

        var proto = new GetDropLimitActivityRsp
        {
            DropLimitActivityList =
            {
                new DropLimitActivity
                {
                    ActivityId = 1,
                    BeginTime = 1576029600,
                    EndTime = 1891735200,
                    DropLimitGotNumList =
                    {
                        new DropLimitItem { LimitId = 101 },
                        new DropLimitItem { LimitId = 201 },
                        new DropLimitItem { LimitId = 301 },
                        new DropLimitItem { LimitId = 401 }
                    }
                },
                new DropLimitActivity
                {
                    ActivityId = 38,
                    BeginTime = 1624500000,
                    EndTime = 2068056000,
                    DropLimitGotNumList =
                    {
                        new DropLimitItem { LimitId = 3001 },
                        new DropLimitItem { LimitId = 3002, GotNum = 3800 },
                        new DropLimitItem { LimitId = 3003, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3004, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3005, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3006, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3007, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3008, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3010, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3013, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3014, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3015, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3016, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3017, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3019, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3021, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3022, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3026, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3027, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3028, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3031, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3032, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3035, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3036, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3040, GotNum = 210 },
                        new DropLimitItem { LimitId = 3042, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3043, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3045, GotNum = 430 },
                        new DropLimitItem { LimitId = 3047, GotNum = 430 },
                        new DropLimitItem { LimitId = 3048, GotNum = 430 },
                        new DropLimitItem { LimitId = 3049, GotNum = 1500 },
                        new DropLimitItem { LimitId = 3050, GotNum = 430 },
                        new DropLimitItem { LimitId = 3051, GotNum = 465 },
                        new DropLimitItem { LimitId = 3052, GotNum = 465 },
                        new DropLimitItem { LimitId = 3054, GotNum = 505 },
                        new DropLimitItem { LimitId = 3055, GotNum = 505 }
                    }
                },
                new DropLimitActivity
                {
                    ActivityId = 42,
                    BeginTime = 1634004000,
                    EndTime = 1891735200,
                    DropLimitGotNumList =
                    {
                        new DropLimitItem { LimitId = 408 }
                    }
                },
                new DropLimitActivity
                {
                    ActivityId = 45,
                    BeginTime = 1644264000,
                    EndTime = 1975780800,
                    DropLimitGotNumList =
                    {
                        new DropLimitItem { LimitId = 4001 }
                    }
                },
                new DropLimitActivity
                {
                    ActivityId = 47,
                    BeginTime = 1668045600,
                    EndTime = 1976558400,
                    DropLimitGotNumList =
                    {
                        new DropLimitItem { LimitId = 4003, GotNum = 360 }
                    }
                },
                new DropLimitActivity
                {
                    ActivityId = 48,
                    BeginTime = 1668045600,
                    EndTime = 1976558400,
                    DropLimitGotNumList =
                    {
                        new DropLimitItem { LimitId = 4006 }
                    }
                },
                new DropLimitActivity
                {
                    ActivityId = 49,
                    BeginTime = 1668045600,
                    EndTime = 1976558400,
                    DropLimitGotNumList =
                    {
                        new DropLimitItem { LimitId = 4010, GotNum = 1050 },
                        new DropLimitItem { LimitId = 4012, GotNum = 600 }
                    }
                },
                new DropLimitActivity
                {
                    ActivityId = 50,
                    BeginTime = 1673740800,
                    EndTime = 1976558400
                }
            }
        };

        SetData(proto);
    }
}
