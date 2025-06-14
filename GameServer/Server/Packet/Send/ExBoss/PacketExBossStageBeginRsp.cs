using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.ExBoss;

public class PacketExBossStageBeginRsp : BasePacket
{
    public PacketExBossStageBeginRsp() : base(CmdIds.ExBossStageBeginRsp)
    {
        var proto = new ExBossStageBeginRsp
        {
        
        };

        SetData(proto);
    }
}
