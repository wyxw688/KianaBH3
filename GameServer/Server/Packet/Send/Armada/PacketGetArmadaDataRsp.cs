using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Armada;

public class PacketGetArmadaDataRsp : BasePacket
{
    public PacketGetArmadaDataRsp() : base(CmdIds.GetArmadaDataRsp)
    {
        var proto = new GetArmadaDataRsp
        {
        
        };

        SetData(proto);
    }
}
