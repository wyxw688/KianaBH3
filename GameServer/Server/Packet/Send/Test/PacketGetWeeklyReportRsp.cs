using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketGetWeeklyReportRsp : BasePacket
{
    public PacketGetWeeklyReportRsp(PlayerInstance player) : base(CmdIds.GetWeeklyReportRsp)
    {
        var proto = new GetWeeklyReportRsp
        {
            Retcode = GetWeeklyReportRsp.Types.Retcode.Fail,
            TargetUid = (uint)player.Data.Uid,
        };

        SetData(proto);
    }
}
