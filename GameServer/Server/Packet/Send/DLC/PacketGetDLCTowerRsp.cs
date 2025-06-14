using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.DLC;

public class PacketGetDLCTowerRsp : BasePacket
{
    public PacketGetDLCTowerRsp() : base(CmdIds.GetDLCTowerRsp)
    {
        var proto = new GetDLCTowerRsp
        {
        
        };

        SetData(proto);
    }
}
