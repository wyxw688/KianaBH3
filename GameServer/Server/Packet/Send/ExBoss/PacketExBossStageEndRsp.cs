using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.ExBoss;

public class PacketExBossStageEndRsp : BasePacket
{
    public PacketExBossStageEndRsp(uint bossId, StageEndStatus Status) : base(CmdIds.ExBossStageEndRsp)
    {
        var proto = new ExBossStageEndRsp
        {
            BossId = bossId,
            EndStatus = Status
        };

        SetData(proto);
    }
}
