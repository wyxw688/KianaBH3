using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Adventure;

public class PacketGetAdventureGroupRsp : BasePacket
{
    public PacketGetAdventureGroupRsp() : base(CmdIds.GetAdventureGroupRsp)
    {
        var proto = new GetAdventureGroupRsp
        {
        
        };

        SetData(proto);
    }
}
