using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Pjms;

public class PacketPjmsGetActivityPanelRsp : BasePacket
{
    public PacketPjmsGetActivityPanelRsp() : base(CmdIds.PjmsGetActivityPanelRsp)
    {
        // TODO: Hardcoded
        var proto = new PjmsGetActivityPanelRsp
        {
            ActivityPanelList =
            {
                new PjmsActivityPanel
                {
                    ActivityId = 1001,
                    AdvanceBeginTime = 1712800800,
                    AdvanceEndTime = 1716494399,
                    BeginTime = 1712800800,
                    EndTime = 4294967295,
                    IsResident = true,
                    MinLevel = 30
                },
                new PjmsActivityPanel
                {
                    ActivityId = 1002,
                    AdvanceBeginTime = 1718848800,
                    AdvanceEndTime = 1721851199,
                    BeginTime = 1718848800,
                    EndTime = 4294967295,
                    IsResident = true,
                    MinLevel = 30
                },
                new PjmsActivityPanel
                {
                    ActivityId = 1003,
                    AdvanceBeginTime = 1718157600,
                    AdvanceEndTime = 1725479999,
                    BeginTime = 1712887200,
                    EndTime = 4294967295,
                    IsResident = true,
                    MinLevel = 30
                },
                new PjmsActivityPanel
                {
                    ActivityId = 1004,
                    AdvanceBeginTime = 1726452000,
                    AdvanceEndTime = 1729108799,
                    BeginTime = 1726452000,
                    EndTime = 4294967295,
                    IsResident = true,
                    MinLevel = 30
                }
            }
        };

        SetData(proto);
    }
}
