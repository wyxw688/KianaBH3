using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetGardenScheduleRsp : BasePacket
{
    public PacketGetGardenScheduleRsp() : base(CmdIds.GetGardenScheduleRsp)
    {
        var proto = new GetGardenScheduleRsp
        {
        
        };

        SetData(proto);
    }
}
