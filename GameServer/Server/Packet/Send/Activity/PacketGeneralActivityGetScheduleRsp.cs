using KianaBH.Data;
using KianaBH.KcpSharp;
using KianaBH.Proto;
using KianaBH.Util.Extensions;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGeneralActivityGetScheduleRsp : BasePacket
{
    public PacketGeneralActivityGetScheduleRsp() : base(CmdIds.GeneralActivityGetScheduleRsp)
    {
        // TODO : Add new character tutorial

        var time = (uint)Extensions.GetUnixSec() + 3600 * 24 * 7;

        var proto = new GeneralActivityGetScheduleRsp();

        foreach (var tutorial in GameData.AvatarTutorialData.Values)
        {
            proto.ScheduleList.Add(new GeneralActivityScheduleInfo
            {
                ActivityId = tutorial.ActivityID,
                SettleTime = time,
                EndDayTime = time,
                EndTime = time,
            });
        }

        foreach (var tower in GameData.ActivityTowerData.Values)
        {
            proto.ScheduleList.Add(new GeneralActivityScheduleInfo
            {
                ActivityId = tower.ActivityID,
                SettleTime = time,
                EndDayTime = time,
                EndTime = time,
            });
        }

        SetData(proto);
    }
}
