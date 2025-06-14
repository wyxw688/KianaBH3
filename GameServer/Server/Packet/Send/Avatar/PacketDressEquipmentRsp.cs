using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Avatar;

public class PacketDressEquipmentRsp : BasePacket
{
    public PacketDressEquipmentRsp() : base(CmdIds.DressEquipmentRsp)
    {
        // TODO: Implement
        var proto = new DressEquipmentRsp
        {
        
        };

        SetData(proto);
    }
}
