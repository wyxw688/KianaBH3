using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Avatar;

public class PacketUpdateCustomAvatarTeamRsp : BasePacket
{
    public PacketUpdateCustomAvatarTeamRsp() : base(CmdIds.UpdateCustomAvatarTeamRsp)
    {
        var proto = new UpdateCustomAvatarTeamRsp
        {
        
        };

        SetData(proto);
    }
}
