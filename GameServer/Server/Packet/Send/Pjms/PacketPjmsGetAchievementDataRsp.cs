using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Pjms;

public class PacketPjmsGetAchievementDataRsp : BasePacket
{
    public PacketPjmsGetAchievementDataRsp() : base(CmdIds.PjmsGetAchievementDataRsp)
    {
        var proto = new PjmsGetAchievementDataRsp
        {
        
        };

        SetData(proto);
    }
}
