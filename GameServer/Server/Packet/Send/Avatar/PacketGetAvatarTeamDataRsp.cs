using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Avatar;

public class PacketGetAvatarTeamDataRsp : BasePacket
{
    public PacketGetAvatarTeamDataRsp() : base(CmdIds.GetAvatarTeamDataRsp)
    {
        var proto = new GetAvatarTeamDataRsp // TODO: Add Lineup
        {
        
        };

        SetData(proto);
    }
}
