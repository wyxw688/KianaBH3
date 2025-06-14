using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Avatar;

public class PacketDelCustomAvatarTeamRsp : BasePacket
{
    public PacketDelCustomAvatarTeamRsp() : base(CmdIds.DelCustomAvatarTeamRsp)
    {
        var proto = new DelCustomAvatarTeamRsp
        {
        
        };

        SetData(proto);
    }
}
