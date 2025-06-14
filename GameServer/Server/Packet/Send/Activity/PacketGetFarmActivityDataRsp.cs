using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetFarmActivityDataRsp : BasePacket
{
    public PacketGetFarmActivityDataRsp() : base(CmdIds.GetFarmActivityDataRsp)
    {
        var proto = new GetFarmActivityDataRsp
        {
        
        };

        SetData(proto);
    }
}
