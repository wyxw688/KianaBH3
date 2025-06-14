using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketSetWarshipAvatarRsp : BasePacket
{
    public PacketSetWarshipAvatarRsp() : base(CmdIds.SetWarshipAvatarRsp)
    {
        var proto = new SetWarshipAvatarRsp
        {
        
        };

        SetData(proto);
    }
}
