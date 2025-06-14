using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetInviteActivityInviterDataRsp : BasePacket
{
    public PacketGetInviteActivityInviterDataRsp() : base(CmdIds.GetInviteActivityInviterDataRsp)
    {
        // TODO: Hardcoded
        var proto = new GetInviteActivityInviterDataRsp
        {
            InviterActivityInfoList =
            {
                new InviterActivity
                {
                    ScheduleId = 4
                },
                new InviterActivity
                {
                    ScheduleId = 103
                }
            },
            MyInviteCode = "17263334YG"
        };

        SetData(proto);
    }
}
