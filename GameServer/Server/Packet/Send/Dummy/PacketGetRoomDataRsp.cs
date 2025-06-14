using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetRoomDataRsp : BasePacket
{
    public PacketGetRoomDataRsp() : base(CmdIds.GetRoomDataRsp)
    {
        var proto = new GetRoomDataRsp
        {
        
        };

        SetData(proto);
    }
}
