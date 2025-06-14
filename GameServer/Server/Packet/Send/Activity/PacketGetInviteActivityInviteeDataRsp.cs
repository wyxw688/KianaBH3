using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetInviteActivityInviteeDataRsp : BasePacket
{
    public PacketGetInviteActivityInviteeDataRsp() : base(CmdIds.GetInviteActivityInviteeDataRsp)
    {
        // TODO: Hardcoded
        var proto = new GetInviteActivityInviteeDataRsp
        {
            InviteeActivityInfoList =
            {
                new InviteeActivity
                {
                    ScheduleId = 2,
                    ActivityType = InviteeActivityType.Goback
                }
            }
        };

        SetData(proto);
    }
}
