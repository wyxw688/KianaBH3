using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketGetWeeklyRoutineActivityRsp : BasePacket
{
    public PacketGetWeeklyRoutineActivityRsp() : base(CmdIds.GetWeeklyRoutineActivityRsp)
    {
        var proto = new GetWeeklyRoutineActivityRsp
        {
        
        };

        SetData(proto);
    }
}
