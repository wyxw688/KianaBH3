using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Avatar;

public class PacketAddCustomAvatarTeamRsp : BasePacket
{
    public PacketAddCustomAvatarTeamRsp() : base(CmdIds.AddCustomAvatarTeamRsp)
    {
        var proto = new AddCustomAvatarTeamRsp
        {
        
        };

        SetData(proto);
    }
}
