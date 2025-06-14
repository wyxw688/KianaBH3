using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.OpenWorld;

public class PacketGetOpenworldMechaDefenseRsp : BasePacket
{
    public PacketGetOpenworldMechaDefenseRsp() : base(CmdIds.GetOpenworldMechaDefenseRsp)
    {
        var proto = new GetOpenworldMechaDefenseRsp
        {
            MechaDefense = new OpenworldMechaDefense
            {
                LeftEnterTimes = 1
            }
        };

        SetData(proto);
    }
}
